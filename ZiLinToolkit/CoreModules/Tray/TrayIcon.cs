namespace ZiLinToolkit.CoreModules.Tray
{
    public partial class TrayIcon
    {
        private static NotifyIcon NotifyIcon = new()
        {
            Text = "ZiLinToolkit",
            Icon = new Icon("tool.ico"),
            ContextMenuStrip = new ContextMenuStrip(),
            Visible = true,
        };

        private static List<ToolStripItem> TrayMenuItems = [];

        public TrayIcon() => Initialize();
    }
}
