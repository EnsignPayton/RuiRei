using RuiRei.Core.Models;

namespace RuiRei.Core.Services;

public class WordService
{
    private readonly Word[] _data =
    {
        new("てんき", "天気")
        {
            Kanji = { "天", "気" },
            JlptLevel = 5
        },
        new("きぶん", "気分")
        {
            Kanji = { "気", "分" },
            JlptLevel = 5
        }
    };

    public IEnumerable<Word> Get() => _data;
}
