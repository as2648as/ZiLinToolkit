using System.Windows;
using ZiLinToolkit.Utility.Tray;
using Application = System.Windows.Application;

namespace ZiLinToolkit
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static Mutex? _mutex;

        protected override void OnStartup(StartupEventArgs e)
        {
            const string mutexName = "ZiLinToolkitMutex";

            // 檢查是否已有實例在運行
            _mutex = new Mutex(true, mutexName, out bool isCreatedNew);

            if (!isCreatedNew)
            {
                Current.Shutdown();
                return;
            }

            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            Tray.Hidden();

            base.OnExit(e);
        }
    }
}
