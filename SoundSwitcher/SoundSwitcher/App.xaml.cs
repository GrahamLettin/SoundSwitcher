using System.Windows;
using Forms = System.Windows.Forms;

namespace SoundSwitcher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Forms.NotifyIcon NotifyIcon;
        public App()
        {
            NotifyIcon = new();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            NotifyIcon.Icon = new System.Drawing.Icon("Resources/Icons/TrayIcon.ico");
            NotifyIcon.ContextMenuStrip = new Forms.ContextMenuStrip();
            NotifyIcon.ContextMenuStrip.Items.Add("Test 1");
            NotifyIcon.ContextMenuStrip.Items.Add("Test 2");

            NotifyIcon.Visible = true;
        }

        protected override void OnExit(ExitEventArgs e)
        {
            NotifyIcon.Dispose();
            base.OnExit(e);
        }
    }
}
