namespace RuiRei.Core.Models;

public class Definition
{
    public string Term { get; set; } = string.Empty;
    public IList<Sense> Senses { get; set; } = new List<Sense>();
}
