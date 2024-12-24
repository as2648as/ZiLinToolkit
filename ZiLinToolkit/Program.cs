using ZiLinToolkit.App.Providers;

namespace ZiLinToolkit
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Initialize
            ApplicationConfiguration.Initialize();

            // Providers f
            _ = new MainProvider();

            // App Run
            Application.Run();
        }
    }
}