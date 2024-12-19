using ZiLinToolkit.CoreModules.Tray.MenuItems;

namespace ZiLinToolkit.CoreModules.Tray
{
    public partial class TrayIcon
    {
        private static List<ToolStripItem> DefaultItems = [
            new ToolStripSeparator(),
            new OptionsMenuItem(),
            new ExitMenuItem(),
        ];
    }
}
