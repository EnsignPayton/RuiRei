using JishoNET.Models;
using RuiRei.Core.Models;

namespace RuiRei.Core.Services;

public class DictionaryService : IDictionaryService
{
    public IEnumerable<Definition> Search(string keyword)
    {
        var client = new JishoClient();
        var response = client.GetDefinition(keyword);

        if (!response.Success)
            throw new Exception(response.Exception);

        return response.Data
            .Select(jDef => new Definition
            {
                Term = jDef.Slug,
                Senses = jDef.Senses
                    .Select(jSense => new Sense
                    {
                        PartsOfSpeech = jSense.PartsOfSpeech,
                        Meanings = jSense.EnglishDefinitions
                    })
                    .ToList()
            });
    }

    public Task<IEnumerable<Definition>> SearchAsync(string keyword) =>
        Task.Run(() => Search(keyword));
}
