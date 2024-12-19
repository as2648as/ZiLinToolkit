using ZiLinToolkit.CoreModules.Tray;

namespace ZiLinToolkit.App.Providers.Tray
{
    public class TrayProvider
    {
        private static TrayIcon TrayIcon { get; set; } = null!;

        public TrayProvider() => TrayIcon = new TrayIcon();
    }
}
