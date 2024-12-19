namespace ZiLinToolkit.CoreModules.Tray.MenuItems
{
    public class ExitMenuItem : ToolStripMenuItem
    {
        public ExitMenuItem()
        {
            Text = "退出";

            Click += Exit_Click;
        }

        private void Exit_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
