using ZiLinToolkit.CoreModules.Tray.MenuItems;

namespace ZiLinToolkit.CoreModules.Tray
{
    public partial class TrayIcon
    {
        public void Initialize()
        {
            DefaultItems = [
                new ToolStripSeparator(),
                new OptionsMenuItem(this),
                new ExitMenuItem(),
            ];

            ReloadMenuItems();
        }

        private static void ReloadMenuItems()
        {
            NotifyIcon.ContextMenuStrip?.Items.Clear();
            NotifyIcon.ContextMenuStrip!.Items.AddRange(TrayMenuItems.ToArray());
            NotifyIcon.ContextMenuStrip!.Items.AddRange(DefaultItems.ToArray());
        }

        public static void AddMenuItems(List<ToolStripItem> toolStripItems)
        {
            TrayMenuItems.AddRange(toolStripItems);
            ReloadMenuItems();
        }
    }
}
