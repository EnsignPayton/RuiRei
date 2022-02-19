using RuiRei.Core.Models;

namespace RuiRei.Core.Services;

public class SearchService
{
    private readonly KanjiService _kanjiService = new();
    private readonly WordService _wordService = new();

    public Task<IEnumerable<Kanji>> SearchKanji(string keyword) => _kanjiService.Get()
        .Where(kanji => kanji.Kunyoumi.Any(youmi => youmi.Contains(keyword)) ||
                        kanji.Onyoumi.Any(youmi => youmi.Contains(keyword)) ||
                        kanji.Description.Contains(keyword))
        .ToTask()
        .WithDelay(TimeSpan.FromSeconds(2));

    public Task<IEnumerable<Word>> SearchWords(string keyword) => _wordService.Get()
        .Where(word => word.ValueKana.Contains(keyword) ||
                       word.ValueKanji.Contains(keyword) ||
                       word.Kanji.Contains(keyword))
        .ToTask()
        .WithDelay(TimeSpan.FromSeconds(1));
}
