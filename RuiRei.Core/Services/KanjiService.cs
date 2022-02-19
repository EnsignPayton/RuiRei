using RuiRei.Core.Models;

namespace RuiRei.Core.Services;

public class KanjiService
{
    private readonly Kanji[] _data = {
        new("一", 1, "one")
        {
            Parts = { "一" },
            Kunyoumi = { "ひとー", "ひとつ" },
            Onyoumi = { "いち", "いつ" },
            Grade = 1,
            JlptLevel = 5
        },
        new("二", 2, "two")
        {
            Parts = { "二" },
            Kunyoumi = { "ふた", "ふたつ", "ふたたび" },
            Onyoumi = { "に", "じ" },
            Grade = 1,
            JlptLevel = 5
        },
        new("大", 3, "large")
        {
            Parts = { "大" },
            Kunyoumi = { "おおー", "おおきい", "ーおおいに" },
            Onyoumi = { "だい", "たい" },
            Grade = 1,
            JlptLevel = 5
        },
        new("天", 4, "heavens, sky, imperial")
        {
            Parts = { "一", "二", "大" },
            Kunyoumi = { "あまつ", "あめ", "あまー" },
            Onyoumi = { "てん" },
            Grade = 1,
            JlptLevel = 5
        },
        new("気", 6, "spirit, mind, air, atmosphere, mood")
        {
            Parts = { "気" },
            Kunyoumi = { "き" },
            Onyoumi = { "き", "け" },
            Grade = 1,
            JlptLevel = 5
        },
        new("刀", 2, "sword, saber, knife")
        {
            Parts = { "刀" },
            Kunyoumi = { "かたな", "そり" },
            Onyoumi = { "とう" },
            Grade = 2,
            JlptLevel = 1
        },
        new("分", 4, "part, minute of time, segment, share, degree")
        {
            Parts = { "刀" },
            Kunyoumi = { "わける", "わけ", "わかれる", "わかる", "わかつ" },
            Onyoumi = { "ぶん", "ふん", "ぶ" },
            Grade = 2
        }
    };

    public IEnumerable<Kanji> Get() => _data;
}
