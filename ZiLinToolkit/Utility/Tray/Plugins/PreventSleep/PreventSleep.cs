using System.Runtime.InteropServices;

namespace ZiLinToolkit.Utility.Tray.Plugins.PreventSleep
{
    public class PreventSleep
    {
        public static bool IsEnable { get; private set; } = false;
        const uint ES_AWAYMODE_REQUIRED = 0x00000040;
        const uint ES_CONTINUOUS = 0x80000000; const uint ES_DISPLAY_REQUIRED = 0x00000002;
        const uint ES_SYSTEM_REQUIRED = 0x00000001;

        public void Dispose() => Disable();

        public static void Toggle()
        {
            if (IsEnable) Disable(); else Enable();
        }

        // 設置執行狀態，防止系統休眠、鎖定、關閉螢幕
        private static void Enable()
        {
            IsEnable = true;
            SetThreadExecutionState(ES_CONTINUOUS | ES_SYSTEM_REQUIRED | ES_DISPLAY_REQUIRED | ES_AWAYMODE_REQUIRED);
        }

        // 恢復系統狀態
        private static void Disable()
        {
            IsEnable = false;
            SetThreadExecutionState(ES_CONTINUOUS);
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern uint SetThreadExecutionState(uint esFlags); // 定義執行狀態標誌
    }
}
