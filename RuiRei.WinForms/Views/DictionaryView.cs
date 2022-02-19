using System.Reactive.Disposables;
using ReactiveUI;
using RuiRei.Reactive.Services;
using RuiRei.Reactive.ViewModels;

namespace RuiRei.WinForms.Views;

public partial class DictionaryView : UserControl, IViewFor<DictionaryViewModel>
{
    public DictionaryView()
    {
        InitializeComponent();

        ViewModel = new DictionaryViewModel(new DictionaryService());

        this.WhenActivated(disposable =>
        {
            this.OneWayBind(ViewModel,
                    vm => vm.IsAvailable,
                    v => v.lbResult.Visible)
                .DisposeWith(disposable);

            this.OneWayBind(ViewModel,
                    vm => vm.Result,
                    v => v.lbResult.Controls,
                    vmToViewConverterOverride: new ListBoxItemConverter())
                .DisposeWith(disposable);

            this.Bind(ViewModel,
                    vm => vm.Term,
                    v => v.tbTerm.Text)
                .DisposeWith(disposable);
        });
    }

    object? IViewFor.ViewModel
    {
        get => ViewModel;
        set => ViewModel = (DictionaryViewModel?) value;
    }

    public DictionaryViewModel? ViewModel { get; set; }
}
