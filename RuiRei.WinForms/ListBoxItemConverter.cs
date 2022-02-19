using System.Collections;
using ReactiveUI;
using ReactiveUI.Winforms;

namespace RuiRei.WinForms;

internal class ListBoxItemConverter : IBindingTypeConverter
{
    public int GetAffinityForObjects(Type fromType, Type toType)
    {
        if (toType != typeof(Control.ControlCollection)) return 0;
        if (fromType.GetInterface("IEnumerable") == null) return 0;
        return 10;
    }

    public bool TryConvert(object? from, Type toType, object? conversionHint, out object? result)
    {
        if (from is not IEnumerable enumerable)
        {
            result = null;
            return false;
        }

        result = enumerable
            .Cast<object?>()
            .Select(vm => new ViewModelControlHost { ViewModel = vm, Dock = DockStyle.Top })
            .ToList();

        return true;
    }
}
