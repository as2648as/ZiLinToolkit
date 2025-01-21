using System.Windows;
using ZiLinToolkit.Utility.Tray;

namespace ZiLinToolkit
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Tray _ = new();
        }
    }
}
