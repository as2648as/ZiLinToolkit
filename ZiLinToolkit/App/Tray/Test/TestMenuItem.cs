namespace ZiLinToolkit.App.Tray.Test
{
    public class TestMenuItem : ToolStripMenuItem
    {
        public TestMenuItem()
        {
            Text = "測試";
            Click += TestMenuItem_Click;
        }

        private void TestMenuItem_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("測試");
        }
    }
}
