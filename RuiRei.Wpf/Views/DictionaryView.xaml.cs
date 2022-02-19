using System.Reactive.Disposables;
using ReactiveUI;
using RuiRei.Reactive.Services;
using RuiRei.Reactive.ViewModels;

namespace RuiRei.Wpf.Views;

public partial class DictionaryView
{
    public DictionaryView()
    {
        InitializeComponent();

        ViewModel = new DictionaryViewModel(new DictionaryService());

        this.WhenActivated(disposable =>
        {
            this.OneWayBind(ViewModel,
                    vm => vm.IsAvailable,
                    v => v.ResultBox.Visibility)
                .DisposeWith(disposable);

            this.OneWayBind(ViewModel,
                    vm => vm.Result,
                    v => v.ResultBox.ItemsSource)
                .DisposeWith(disposable);

            this.Bind(ViewModel,
                    vm => vm.Term,
                    v => v.TermBox.Text)
                .DisposeWith(disposable);
        });
    }
}
