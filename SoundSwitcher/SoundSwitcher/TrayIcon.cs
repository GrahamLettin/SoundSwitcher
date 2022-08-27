using System.Windows;
using Forms = System.Windows.Forms;
namespace SoundSwitcher
{
    internal class TrayIcon
    {
        private readonly Forms.NotifyIcon NotifyIcon;
        public TrayIcon()
        {
            NotifyIcon = new();
            NotifyIcon.Icon = new System.Drawing.Icon("Resources/Icons/TrayIcon.ico");
            NotifyIcon.Click += NotifyIcon_Click;

            NotifyIcon.Visible = true;
        }

        private void NotifyIcon_Click(object? sender, System.EventArgs e)
        {
            //MessageBox.Show("Clicked!");
            var customContextWindow = new CustomContextMenu();
            customContextWindow.Show();
        }

        public void Dispose() => NotifyIcon.Dispose();
    }
}
