using ZiLinToolkit.Utility.Tray.Plugins;
using ZiLinToolkit.Utility.Tray.Plugins.Default;
using ZiLinToolkit.Utility.Tray.Plugins.InputLocker;
using ZiLinToolkit.Utility.Tray.Plugins.PreventSleep;

namespace ZiLinToolkit.Utility.Tray
{
    public partial class Tray
    {
        private readonly static NotifyIcon NotifyIcon = new();
        private readonly static OptionWindow OptionWindow = new();
        private static BasePlugin[] BasePlugins { get; set; } = [];

        public Tray()
        {
            BasePlugins = [
                new InputLockerPlugin(),
                new PreventSleepPlugin(),
                new DefaultPlugin(),
            ];

            InitializeTray(); // 初始化 Tray
        }

        private static void InitializeTray()
        {
            // 初始化 NotifyIcon
            NotifyIcon.Text = "ZiLinToolKit";
            NotifyIcon.Icon = new Icon("./Properties/ico/tool-01.ico");
            NotifyIcon.ContextMenuStrip = new ContextMenuStrip();
            NotifyIcon.Visible = true;

            InitializeContextMenuStripItems(); // 初始化右鍵選單
            InitializeTabPages();              // 初始化選項清單
        }

        private static void InitializeContextMenuStripItems()
        {
            if (NotifyIcon.ContextMenuStrip == null) throw new ArgumentNullException("ContextMenuStrip is null.");

            for (int i = 0; i < BasePlugins.Length; ++i)
            {
                if (i != 0) NotifyIcon.ContextMenuStrip.Items.Add(new ToolStripSeparator());

                ToolStripMenuItem pluginHeader = new()
                {
                    Text = BasePlugins[i].Name,
                    Enabled = false,
                    BackColor = Color.FromArgb(255, 220, 220, 220)
                };

                pluginHeader.Font = new Font(pluginHeader.Font, FontStyle.Bold);

                NotifyIcon.ContextMenuStrip.Items.Add(pluginHeader);
                NotifyIcon.ContextMenuStrip.Items.Add(new ToolStripSeparator());
                NotifyIcon.ContextMenuStrip.Items.AddRange(BasePlugins[i].ToolStripItems);
            }
        }

        private static void InitializeTabPages() { }

        public static void PopOutMessage(string title, string message, int timeout = 3)
        {
            NotifyIcon.BalloonTipTitle = title;
            NotifyIcon.BalloonTipText = message;
            NotifyIcon.ShowBalloonTip(timeout);
        }

        public static void Hidden()
        {
            NotifyIcon.Visible = false;
        }
    }
}
