using RuiRei.Core.Models;

namespace RuiRei.Core.Services;

public interface IDictionaryService
{
    Task<IEnumerable<Definition>> SearchAsync(string keyword);
}
