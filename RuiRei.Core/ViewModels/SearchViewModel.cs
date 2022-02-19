using System.Reactive.Linq;
using ReactiveUI;
using RuiRei.Core.Services;

namespace RuiRei.Core.ViewModels;

public class SearchViewModel : ReactiveObject
{
    private readonly SearchService _searchService = new();
    private readonly ObservableAsPropertyHelper<IEnumerable<KanjiViewModel>?> _kanjiResult;
    private readonly ObservableAsPropertyHelper<IEnumerable<WordViewModel>?> _wordsResult;
    private readonly ObservableAsPropertyHelper<bool> _isAvailable;
    private string _searchTerm = string.Empty;

    public IEnumerable<KanjiViewModel>? KanjiResult => _kanjiResult.Value;
    public IEnumerable<WordViewModel>? WordsResult => _wordsResult.Value;
    public bool IsAvailable => _isAvailable.Value;

    public string SearchTerm
    {
        get => _searchTerm;
        set => this.RaiseAndSetIfChanged(ref _searchTerm, value);
    }

    public SearchViewModel()
    {
        var searchObservable = this
            .WhenAnyValue(x => x.SearchTerm)
            .Throttle(TimeSpan.FromMilliseconds(500))
            .Select(x => x.Trim())
            .DistinctUntilChanged()
            .Where(x => !string.IsNullOrWhiteSpace(x));

        _kanjiResult = searchObservable
            .SelectMany(SearchKanji)
            .ObserveOn(RxApp.MainThreadScheduler)
            .ToProperty(this, x => x.KanjiResult);

        _wordsResult = searchObservable
            .SelectMany(SearchWords)
            .ObserveOn(RxApp.MainThreadScheduler)
            .ToProperty(this, x => x.WordsResult);

        _isAvailable = this
            .WhenAnyValue(x => x.KanjiResult)
            .Select(x => x != null)
            .ToProperty(this, x => x.IsAvailable);
    }

    private async Task<IEnumerable<KanjiViewModel>> SearchKanji(string keyword)
    {
        var kanji = await _searchService.SearchKanji(keyword);
        return kanji.Select(x => new KanjiViewModel(x));
    }

    private async Task<IEnumerable<WordViewModel>> SearchWords(string keyword)
    {
        var words = await _searchService.SearchWords(keyword);
        return words.Select(x => new WordViewModel(x));
    }
}
