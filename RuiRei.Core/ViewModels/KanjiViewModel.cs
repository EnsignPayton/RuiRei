using System.Text;
using ReactiveUI;
using RuiRei.Core.Models;

namespace RuiRei.Core.ViewModels;

public class KanjiViewModel : ReactiveObject
{
    private readonly Kanji _data;

    public KanjiViewModel(Kanji data)
    {
        _data = data;
    }

    public Kanji Data => _data;

    public string BasicInfo => BuildBasicInfo();

    private string BuildBasicInfo()
    {
        var sb = new StringBuilder($"{_data.Strokes} strokes.");
        if (_data.JlptLevel != null)
            sb.Append($" JLPT N{_data.JlptLevel}.");
        if (_data.Grade != null)
            sb.Append($" Taught in grade {_data.Grade}.");
        return sb.ToString();
    }
}
