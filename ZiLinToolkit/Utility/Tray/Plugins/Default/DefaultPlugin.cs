namespace ZiLinToolkit.Utility.Tray.Plugins.Default
{
    public class DefaultPlugin : BasePlugin
    {
        public DefaultPlugin()
        {
            ToolStripItems = [
                Item_InputLocker,
            ];
        }

        private static ToolStripItem Item_InputLocker
        {
            get
            {
                ToolStripMenuItem item = new() { Text = "關閉" };

                item.Click += (sender, e) => System.Windows.Application.Current.Shutdown();

                return item;
            }
        }
    }
}
