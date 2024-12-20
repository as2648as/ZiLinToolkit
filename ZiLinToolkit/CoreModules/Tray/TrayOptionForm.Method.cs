using ZiLinToolkit.CoreModules.Tray.TreeNodes;

namespace ZiLinToolkit.CoreModules.Tray
{
    public partial class TrayOptionForm : Form
    {
        /// <summary>
        /// 新增 Node 至左側選單
        /// </summary>
        /// <param name="node"></param>
        public void AddTreeNodes(TreeNode[] nodes) => TreeView.Nodes.AddRange(nodes);

        /// <summary>
        /// 設定右側 Panel 為輸入之內容
        /// </summary>
        /// <param name="control"></param>
        public void SetRightPanelContent(Control control) => RightPanel.Controls.Add(control);

        /// <summary>
        /// 點選 Node 時的觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void TreeView_NodeMouseClick(object? sender, TreeNodeMouseClickEventArgs e) => ((TrayOptionTreeNode)e.Node).ClickEvent();
    }
}
