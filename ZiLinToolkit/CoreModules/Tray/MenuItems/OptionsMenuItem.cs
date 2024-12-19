namespace ZiLinToolkit.CoreModules.Tray.MenuItems
{
    public class OptionsMenuItem : ToolStripMenuItem
    {
        public OptionsMenuItem()
        {
            Text = "選項";

            Click += Options_Click;
        }

        private void Options_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Clicked");
        }
    }
}
