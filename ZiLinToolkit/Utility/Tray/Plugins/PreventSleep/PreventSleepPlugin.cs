namespace ZiLinToolkit.Utility.Tray.Plugins.PreventSleep
{
    public class PreventSleepPlugin : BasePlugin
    {
        public PreventSleepPlugin()
        {
            ToolStripItems = [
                Item_PreventSleep,
            ];
        }

        private static ToolStripMenuItem Item_PreventSleep = GetPreventSleepItem;

        private static ToolStripMenuItem GetPreventSleepItem
        {
            get
            {
                ToolStripMenuItem item = new() { Text = "關閉待機模式" };

                item.Click += PreventSleep_ItemClick;

                return item;
            }
        }

        private static void PreventSleep_ItemClick(object? sender, EventArgs e)
        {
            PreventSleep.Toggle();

            if (PreventSleep.IsEnable)
            {
                Tray.PopOutMessage("PreventSleep", "已取消待機模式，你的電腦將不會進入鎖定、休眠，並且取消了自動關閉螢幕。");
                Item_PreventSleep.CheckState = CheckState.Checked;
            }
            else
            {
                Tray.PopOutMessage("PreventSleep", "恢復系統預設");
                Item_PreventSleep.CheckState = CheckState.Unchecked;
            }
        }
    }
}
