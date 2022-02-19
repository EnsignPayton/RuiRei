using System.Reactive.Disposables;
using ReactiveUI;

namespace RuiRei.Wpf.Views;

public partial class DefinitionView
{
    public DefinitionView()
    {
        InitializeComponent();

        this.WhenActivated(disposable =>
        {
            this.OneWayBind(ViewModel,
                    vm => vm.Term,
                    v => v.TermBlock.Text)
                .DisposeWith(disposable);

            this.OneWayBind(ViewModel,
                    vm => vm.Senses,
                    v => v.SensesControl.ItemsSource)
                .DisposeWith(disposable);
        });
    }
}
