using System.Windows;
using Forms = System.Windows.Forms;
namespace SoundSwitcher
{
    internal class TrayIcon
    {
        private Forms.NotifyIcon NotifyIcon { get; }
        private CustomContextMenu CustomContextMenu { get; }
        public TrayIcon()
        {
            NotifyIcon = new();
            NotifyIcon.Icon = new System.Drawing.Icon("Resources/Icons/TrayIcon.ico");
            NotifyIcon.Click += NotifyIcon_Click;

            CustomContextMenu = new CustomContextMenu();
            NotifyIcon.Visible = true;
        }

        private void NotifyIcon_Click(object? sender, System.EventArgs e)
        {
            CustomContextMenu.Show();
        }

        public void Dispose() => NotifyIcon.Dispose();
    }
}
