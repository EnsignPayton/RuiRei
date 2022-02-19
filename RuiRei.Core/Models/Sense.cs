namespace RuiRei.Core.Models;

public class Sense
{
    public IList<string> PartsOfSpeech { get; set; } = new List<string>();
    public IList<string> Meanings { get; set; } = new List<string>();
}
