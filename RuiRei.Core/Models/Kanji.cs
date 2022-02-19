namespace RuiRei.Core.Models;

public record Kanji(string Value, int Strokes, string Description)
{
    public IList<string> Parts { get; } = new List<string>();
    public IList<string> Kunyoumi { get; } = new List<string>();
    public IList<string> Onyoumi { get; } = new List<string>();
    public int? Grade { get; set; }
    public int? JlptLevel { get; set; }
}
