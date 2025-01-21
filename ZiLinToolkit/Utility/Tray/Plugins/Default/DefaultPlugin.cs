namespace ZiLinToolkit.Utility.Tray.Plugins.Default
{
    public class DefaultPlugin : BasePlugin
    {
        public DefaultPlugin()
        {
            ToolStripItems = [
                Item_Exit,
            ];
        }

        private static ToolStripItem Item_Exit
        {
            get
            {
                ToolStripMenuItem item = new() { Text = "關閉" };

                item.Click += Exit_ItemClick;

                return item;
            }
        }

        private static void Exit_ItemClick(object? sender, EventArgs e)
        {
            Tray.Hidden();
            System.Windows.Application.Current.Shutdown();
        }
    }
}
