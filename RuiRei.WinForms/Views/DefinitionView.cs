using System.Reactive.Disposables;
using ReactiveUI;
using RuiRei.Reactive.ViewModels;

namespace RuiRei.WinForms.Views;

public partial class DefinitionView : UserControl, IViewFor<DefinitionViewModel>
{
    public DefinitionView()
    {
        InitializeComponent();

        this.WhenActivated(disposable =>
        {
            this.OneWayBind(ViewModel,
                    vm => vm.Term,
                    v => v.lblTerm.Text)
                .DisposeWith(disposable);

            this.OneWayBind(ViewModel,
                    vm => vm.Senses,
                    v => v.lbSenses.Controls,
                    vmToViewConverterOverride: new ListBoxItemConverter())
                .DisposeWith(disposable);
        });
    }

    object? IViewFor.ViewModel
    {
        get => ViewModel;
        set => ViewModel = (DefinitionViewModel?) value;
    }

    public DefinitionViewModel? ViewModel { get; set; }
}
