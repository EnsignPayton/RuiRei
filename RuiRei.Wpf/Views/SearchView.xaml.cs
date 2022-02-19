using System.Reactive.Disposables;
using ReactiveUI;
using RuiRei.Core.ViewModels;

namespace RuiRei.Wpf.Views;

public partial class SearchView
{
    public SearchView()
    {
        InitializeComponent();

        ViewModel = new SearchViewModel();

        this.WhenActivated(disposable =>
        {
            this.Bind(ViewModel,
                    vm => vm.SearchTerm,
                    v => v.SearchBox.Text)
                .DisposeWith(disposable);

            this.OneWayBind(ViewModel,
                    vm => vm.KanjiResult,
                    v => v.KanjiResultsBox.ItemsSource)
                .DisposeWith(disposable);

            this.OneWayBind(ViewModel,
                    vm => vm.IsAvailable,
                    v => v.KanjiResultsBox.Visibility)
                .DisposeWith(disposable);
        });
    }
}
