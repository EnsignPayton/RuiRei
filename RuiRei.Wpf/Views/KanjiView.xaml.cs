using System.Reactive.Disposables;
using ReactiveUI;

namespace RuiRei.Wpf.Views;

public partial class KanjiView
{
    public KanjiView()
    {
        InitializeComponent();

        this.WhenActivated(disposable =>
        {
            this.OneWayBind(ViewModel,
                    vm => vm.BasicInfo,
                    v => v.BasicInfoBlock.Text)
                .DisposeWith(disposable);

            this.OneWayBind(ViewModel,
                    vm => vm.Data.Value,
                    v => v.ValueBlock.Text)
                .DisposeWith(disposable);

            this.OneWayBind(ViewModel,
                    vm => vm.Data.Description,
                    v => v.DescriptionBlock)
                .DisposeWith(disposable);
        });
    }
}
