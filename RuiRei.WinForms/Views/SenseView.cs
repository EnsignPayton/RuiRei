using System.Reactive.Disposables;
using ReactiveUI;
using RuiRei.Reactive.ViewModels;

namespace RuiRei.WinForms.Views;

public partial class SenseView : UserControl, IViewFor<SenseViewModel>
{
    public SenseView()
    {
        InitializeComponent();

        this.WhenActivated(disposable =>
        {
            this.OneWayBind(ViewModel,
                    vm => vm.PartsOfSpeech,
                    v => v.lblPartsOfSpeech.Text)
                .DisposeWith(disposable);

            this.OneWayBind(ViewModel,
                    vm => vm.Meanings,
                    v => v.lblMeanings.Text)
                .DisposeWith(disposable);
        });
    }

    object? IViewFor.ViewModel
    {
        get => ViewModel;
        set => ViewModel = (SenseViewModel?) value;
    }

    public SenseViewModel? ViewModel { get; set; }
}
