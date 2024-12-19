using ZiLinToolkit.App.Providers;
using ZiLinToolkit.CoreModules.SQLiteDB;

namespace ZiLinToolkit
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Database.Initialize();
            MainProvider.Initialize();

            Application.Run();
        }
    }
}