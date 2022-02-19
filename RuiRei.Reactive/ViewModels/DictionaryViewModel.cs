using System.Reactive.Linq;
using ReactiveUI;
using RuiRei.Core.Services;

namespace RuiRei.Reactive.ViewModels;

public class DictionaryViewModel : ReactiveObject
{
    private readonly IDictionaryService _service;
    private readonly ObservableAsPropertyHelper<IEnumerable<DefinitionViewModel>?> _result;
    private readonly ObservableAsPropertyHelper<bool> _isAvailable;
    private string _term = string.Empty;

    public IEnumerable<DefinitionViewModel>? Result => _result.Value;

    public bool IsAvailable => _isAvailable.Value;

    public string Term
    {
        get => _term;
        set => this.RaiseAndSetIfChanged(ref _term, value);
    }

    public DictionaryViewModel(IDictionaryService service)
    {
        _service = service;

        _result = this
            .WhenAnyValue(x => x.Term)
            .Throttle(TimeSpan.FromMilliseconds(500))
            .Select(x => x.Trim())
            .DistinctUntilChanged()
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .SelectMany(Search)
            .ObserveOn(RxApp.MainThreadScheduler)
            .ToProperty(this, x => x.Result);

        _isAvailable = this
            .WhenAnyValue(x => x.Result)
            .Select(x => x != null)
            .ToProperty(this, x => x.IsAvailable);
    }

    private async Task<IEnumerable<DefinitionViewModel>> Search(string keyword)
    {
        var result = await _service.SearchAsync(keyword);
        return result.Select(x => new DefinitionViewModel(x));
    }
}
