namespace ZiLinToolkit.CoreModules.Tray
{
    public partial class TrayIcon
    {
        /// <summary>
        /// 共用 Tray 實例
        /// </summary>
        public static NotifyIcon NotifyIcon = null!;

        /// <summary>
        /// 共用 Tray 選項 Form
        /// </summary>
        public static TrayOptionForm TrayOptionForm = new();

        /// <summary>
        /// 外部引入的 Tray 右鍵選單選項
        /// </summary>
        private static List<ToolStripItem> TrayMenuItems = [];

        /// <summary>
        /// 預設的 Tray 右鍵選單選項
        /// </summary>
        private static List<ToolStripItem> DefaultItems = [];

        public TrayIcon() => Initialize();
    }
}
