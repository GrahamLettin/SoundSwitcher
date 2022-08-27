using System.Windows.Forms;
namespace SoundSwitcher
{
    internal class TrayIcon
    {
        private readonly NotifyIcon NotifyIcon;
        public TrayIcon()
        {
            NotifyIcon = new();
            NotifyIcon.Icon = new System.Drawing.Icon("Resources/Icons/TrayIcon.ico");
            NotifyIcon.ContextMenuStrip = new ContextMenuStrip();
            NotifyIcon.ContextMenuStrip.Items.Add("Test 1");
            NotifyIcon.ContextMenuStrip.Items.Add("Test 2");

            NotifyIcon.Visible = true;
        }
        public void Dispose() => NotifyIcon.Dispose();
    }
}
