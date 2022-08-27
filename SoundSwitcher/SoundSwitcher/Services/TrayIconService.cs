using System.Windows.Forms;
namespace SoundSwitcher.Services
{
    internal class TrayIconService
    {
        private NotifyIcon NotifyIcon { get; }
        private CustomContextMenu CustomContextMenu { get; }
        public TrayIconService()
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
            CustomContextMenu.Activate();
        }

        public void Stop() => NotifyIcon.Dispose();
    }
}
