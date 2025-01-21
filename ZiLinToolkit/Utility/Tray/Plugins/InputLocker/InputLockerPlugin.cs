namespace ZiLinToolkit.Utility.Tray.Plugins.InputLocker
{
    public class InputLockerPlugin : BasePlugin
    {
        public InputLockerPlugin()
        {
            ToolStripItems = [
                Item_InputLocker,
            ];
        }

        private static ToolStripMenuItem Item_InputLocker = GetInputLockerItem();

        private static ToolStripMenuItem GetInputLockerItem()
        {
            ToolStripMenuItem item = new() { Text = "輸入鎖定" };

            InputLocker locker = new();

            locker.KeyboardMouseTouchEvent += (s, e) => Tray.PopOutMessage("Somebody toucha my spaghet!", "誰動了我的義大利麵 (´◓Д◔`)?", 1);
            locker.KeyboardMouseLockEvent += (s, e) => Tray.PopOutMessage("Locked！", "鎖定啟用", 1);
            locker.KeyboardMouseUnlockEvent += (s, e) => Tray.PopOutMessage("Unlocked！", "鎖定解除", 1);

            item.Click += InputLocker_ItemClick;

            return item;
        }

        private static void InputLocker_ItemClick(object? sender, EventArgs e)
        {
            InputLocker.Toggle();
            ToggleInputLockerCheckState();
        }

        private static void InputLockerChecked() => Item_InputLocker.CheckState = CheckState.Checked;

        private static void InputLockerUnchecked() => Item_InputLocker.CheckState = CheckState.Unchecked;

        private static void ToggleInputLockerCheckState()
        {
            if (InputLocker.IsEnable)
            {
                InputLockerChecked();
                Tray.PopOutMessage("InputLocker", "使用 Ctrl + Shift + Alt + F12 鎖定輸入，\n使用 Ctrl + Shift + Alt + F11 解除鎖定。");
            }
            else
            {
                InputLockerUnchecked();
            }
        }
    }
}
