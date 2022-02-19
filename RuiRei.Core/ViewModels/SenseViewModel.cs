using ReactiveUI;
using RuiRei.Core.Models;

namespace RuiRei.Core.ViewModels;

public class SenseViewModel : ReactiveObject
{
    private readonly Sense _data;

    public string PartsOfSpeech => string.Join(". ", _data.PartsOfSpeech);
    public string Meanings => string.Join("; ", _data.Meanings);

    public SenseViewModel(Sense data)
    {
        _data = data;
    }
}
