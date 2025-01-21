using System.Runtime.InteropServices;

namespace ZiLinToolkit.Utility.Tray.Plugins.InputLocker
{
    public class InputLocker
    {
        public static bool IsEnable { get => isEnable; private set => isEnable = value; }
        private static bool isEnable;
        private static bool isLocked = false;
        private const int WH_KEYBOARD_LL = 13;
        private const int WH_MOUSE_LL = 14;
        private static LowLevelKeyboardProc _keyboardProc = KeyboardHookCallback;
        private static LowLevelMouseProc _mouseProc = MouseHookCallback;
        private static IntPtr _keyboardHookID = IntPtr.Zero;
        private static IntPtr _mouseHookID = IntPtr.Zero;
        private static InputLocker _instance = null!;

        public delegate void KeyboardMouseTouchHandler(object sender, EventArgs e);
        public event KeyboardMouseTouchHandler KeyboardMouseTouchEvent = null!;
        protected virtual void OnKeyboardMouseTouchEvent(EventArgs e) => KeyboardMouseTouchEvent?.Invoke(this, e);

        public delegate void KeyboardMouseLockHandler(object sender, EventArgs e);
        public event KeyboardMouseLockHandler KeyboardMouseLockEvent = null!;
        public virtual void OnKeyboardMouseLockEvent(EventArgs e) => KeyboardMouseLockEvent?.Invoke(this, e);

        public delegate void KeyboardMouseUnlockHandler(object sender, EventArgs e);
        public event KeyboardMouseUnlockHandler KeyboardMouseUnlockEvent = null!;
        public virtual void OnKeyboardMouseUnlockEvent(EventArgs e) => KeyboardMouseUnlockEvent?.Invoke(this, e);

        public InputLocker()
        {
            IsEnable = false;
            _instance = this;
        }

        public static void Enable()
        {
            _keyboardHookID = SetHook(_keyboardProc);
            _mouseHookID = SetHook(_mouseProc);
            IsEnable = true;
        }

        public static void Disable()
        {
            UnhookWindowsHookEx(_keyboardHookID);
            UnhookWindowsHookEx(_mouseHookID);
            IsEnable = false;
        }

        public static void Toggle()
        {
            if (IsEnable) Disable(); else Enable();
        }

        private static IntPtr SetHook(Delegate proc)
        {
            using var curProcess = System.Diagnostics.Process.GetCurrentProcess();
            using var curModule = curProcess.MainModule;

            return SetWindowsHookEx(
                idHook: proc is LowLevelKeyboardProc ? WH_KEYBOARD_LL : WH_MOUSE_LL,
                lpfn: proc,
                hMod: GetModuleHandle(curModule!.ModuleName),
                dwThreadId: 0
            );
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr KeyboardHookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode < 0) return (IntPtr)1;

            int vkCode = Marshal.ReadInt32(lParam);

            int vkCode_shift = 160;
            int vkCode_ctrl = 162;
            int vkCode_alt = 164;

            bool holdKeys =
                (Control.ModifierKeys & Keys.Control) == Keys.Control &&
                (Control.ModifierKeys & Keys.Shift) == Keys.Shift &&
                (Control.ModifierKeys & Keys.Alt) == Keys.Alt;

            bool pressKeys = (vkCode == vkCode_ctrl) || (vkCode == vkCode_alt) || (vkCode == vkCode_shift);
            bool pressDown = (int)wParam == 256;

            if (holdKeys && pressDown)
            {
                switch (vkCode)
                {
                    case (int)Keys.F12:
                        isLocked = true;
                        _instance.OnKeyboardMouseLockEvent(EventArgs.Empty);
                        break;
                    case (int)Keys.F11:
                        isLocked = false;
                        _instance.OnKeyboardMouseUnlockEvent(EventArgs.Empty);
                        break;
                }
            }
            else if (!pressKeys && isLocked)
            {
                if (pressDown) _instance.OnKeyboardMouseTouchEvent(EventArgs.Empty);
                return (IntPtr)1;
            }

            return CallNextHookEx(_keyboardHookID, nCode, wParam, lParam);
        }

        private static IntPtr MouseHookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode < 0) return CallNextHookEx(_mouseHookID, nCode, wParam, lParam);

            if (isLocked) return (IntPtr)1;

            return CallNextHookEx(_mouseHookID, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, Delegate lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}
