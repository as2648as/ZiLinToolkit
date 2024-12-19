using ZiLinToolkit.App.Providers.Tray;

namespace ZiLinToolkit.App.Providers
{
    public static class MainProvider
    {
        public static void Initialize()
        {
            _ = new TrayProvider();
        }
    }
}
