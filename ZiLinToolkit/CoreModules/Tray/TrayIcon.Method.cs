namespace ZiLinToolkit.CoreModules.Tray
{
    public partial class TrayIcon
    {
        public static void Initialize()
        {
            ReloadMenuItems();
        }

        public static void ReloadMenuItems()
        {
            NotifyIcon.ContextMenuStrip?.Items.Clear();

            NotifyIcon.ContextMenuStrip!.Items.AddRange(DefaultItems.ToArray());
            NotifyIcon.ContextMenuStrip!.Items.AddRange(TrayMenuItems.ToArray());
        }
    }
}
