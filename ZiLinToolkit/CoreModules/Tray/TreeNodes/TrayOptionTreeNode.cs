using ZiLinToolkit.CoreModules.Tray.TreeNodes.Interfaces;

namespace ZiLinToolkit.CoreModules.Tray.TreeNodes
{
    public abstract class TrayOptionTreeNode(TrayIcon trayIcon) : TreeNode, IClickable
    {
        public TrayIcon TrayIcon { get; } = trayIcon;

        public abstract void ClickEvent();
    }
}
