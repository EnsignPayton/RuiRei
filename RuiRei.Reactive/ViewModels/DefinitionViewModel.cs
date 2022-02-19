using ReactiveUI;
using RuiRei.Core.Models;

namespace RuiRei.Reactive.ViewModels;

public class DefinitionViewModel : ReactiveObject
{
    private readonly Definition _data;

    public string Term => _data.Term;

    public IEnumerable<SenseViewModel> Senses { get; }

    public DefinitionViewModel(Definition data)
    {
        _data = data;
        Senses = _data.Senses.Select(x => new SenseViewModel(x));
    }
}
