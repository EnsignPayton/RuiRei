using System.Reflection;
using ReactiveUI;
using Splat;

namespace RuiRei.WinForms;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetCallingAssembly());
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}
