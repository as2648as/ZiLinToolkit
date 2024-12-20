using ZiLinToolkit.App.Tray.Test;
using ZiLinToolkit.CoreModules.Tray;
using ZiLinToolkit.CoreModules.Tray.TreeNodes;

namespace ZiLinToolkit.App.Providers.Tray
{
    public class TrayProvider
    {
        private static readonly TrayIcon TrayIcon = new();
        private static ToolStripItem[] MenuItems { get; set; } = null!;
        private static TrayOptionTreeNode[] TreeNodes { get; set; } = null!;

        public TrayProvider()
        {
            MenuItems = [
                new TestMenuItem(),
            ];

            TreeNodes = [
                new TestTreeNode(TrayIcon),
            ];

            SetTrayOptions();
        }

        private void SetTrayOptions()
        {
            TrayIcon.AddMenuItems(MenuItems);
            TrayIcon.TrayOptionForm.AddTreeNodes(TreeNodes);
        }
    }
}
