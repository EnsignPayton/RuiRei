using ReactiveUI;
using RuiRei.Core.Models;

namespace RuiRei.Core.ViewModels;

public class WordViewModel : ReactiveObject
{
    private readonly Word _data;

    public WordViewModel(Word data)
    {
        _data = data;
    }

    public Word Data => _data;
}
