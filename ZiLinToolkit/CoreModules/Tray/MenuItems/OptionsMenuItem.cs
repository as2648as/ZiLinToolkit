namespace ZiLinToolkit.CoreModules.Tray.MenuItems
{
    public class OptionsMenuItem : ToolStripMenuItem
    {
        private TrayIcon TrayIcon { get; set; } = null!;

        public OptionsMenuItem(TrayIcon trayIcon)
        {
            TrayIcon = trayIcon;

            Text = "選項";

            Click += Options_Click;
        }

        private void Options_Click(object? sender, EventArgs e)
        {
            TrayIcon.TrayOptionForm.Show();
        }
    }
}
