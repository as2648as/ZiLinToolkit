using ZiLinToolkit.CoreModules.Tray.MenuItems;

namespace ZiLinToolkit.CoreModules.Tray
{
    public partial class TrayIcon
    {
        /// <summary>
        /// 初始化 Tray
        /// </summary>
        public void Initialize()
        {
            NotifyIcon = new()
            {
                Text = "ZiLinToolkit",
                Icon = Properties.Resources.TrayIcon,
                ContextMenuStrip = new ContextMenuStrip(),
                Visible = true,
            };

            DefaultItems = [
                new OptionsMenuItem(this),
                new ExitMenuItem(),
            ];

            ReloadMenuItems();
        }

        private static void ReloadMenuItems()
        {
            NotifyIcon.ContextMenuStrip?.Items.Clear();

            if (TrayMenuItems.Count > 0)
            {
                NotifyIcon.ContextMenuStrip!.Items.AddRange(TrayMenuItems.ToArray());
                NotifyIcon.ContextMenuStrip!.Items.Add(new ToolStripSeparator());
            }

            NotifyIcon.ContextMenuStrip!.Items.AddRange(DefaultItems.ToArray());
        }

        public static void AddMenuItems(ToolStripItem[] toolStripItems)
        {
            TrayMenuItems.AddRange(toolStripItems);
            ReloadMenuItems();
        }
    }
}
