namespace ZiLinToolkit.Utility.Tray.Plugins
{
    public abstract class BasePlugin
    {
        private string name = null!;
        private TabPage[] tabPages = [];
        private ToolStripItem[] toolStripItems = [];

        public string Name
        {
            get => name ?? GetType().Name;
            set => name = value;
        }

        public TabPage[] TabPages
        {
            get => tabPages;
            set => tabPages = value;
        }

        public virtual ToolStripItem[] ToolStripItems
        {
            get => toolStripItems;
            set => toolStripItems = value;
        }
    }
}
