namespace RuiRei.Core.Models;

public record Word(string ValueKana, string ValueKanji)
{
    public List<string> Kanji { get; } = new();
    public int? JlptLevel { get; set; }
}
