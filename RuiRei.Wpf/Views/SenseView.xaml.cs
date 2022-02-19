using System.Reactive.Disposables;
using ReactiveUI;

namespace RuiRei.Wpf.Views;

public partial class SenseView
{
    public SenseView()
    {
        InitializeComponent();

        this.WhenActivated(disposable =>
        {
            this.OneWayBind(ViewModel,
                    vm => vm.PartsOfSpeech,
                    v => v.PartsOfSpeechBlock.Text)
                .DisposeWith(disposable);

            this.OneWayBind(ViewModel,
                    vm => vm.Meanings,
                    v => v.MeaningsBlock.Text)
                .DisposeWith(disposable);
        });
    }
}
