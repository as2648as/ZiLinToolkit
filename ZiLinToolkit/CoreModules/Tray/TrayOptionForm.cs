namespace ZiLinToolkit.CoreModules.Tray
{
    public partial class TrayOptionForm : Form
    {
        private static TreeView TreeView { get; set; } = null!;
        private static Panel RightPanel { get; set; } = null!;

        public TrayOptionForm()
        {
            InitializeComponent();

            TreeView = treeView1;
            RightPanel = splitContainer1.Panel2;

            TreeView.NodeMouseClick += TreeView_NodeMouseClick;
        }
    }
}
