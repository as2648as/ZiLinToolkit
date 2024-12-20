using ZiLinToolkit.CoreModules.Tray;
using ZiLinToolkit.CoreModules.Tray.TreeNodes;

namespace ZiLinToolkit.App.Tray.Test
{
    public class TestTreeNode : TrayOptionTreeNode
    {
        public TestTreeNode(TrayIcon trayIcon) : base(trayIcon)
        {
            Text = "測試節點";
        }

        public override void ClickEvent()
        {
            TrayIcon.TrayOptionForm.SetRightPanelContent(new TestForm());
        }
    }
}
