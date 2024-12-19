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

        public readonly static TrayOptionForm TrayOptionForm = new();

        private static List<ToolStripItem> TrayMenuItems = [];
        private static List<ToolStripItem> DefaultItems = [];

        public TrayIcon() => Initialize();
    }
}
