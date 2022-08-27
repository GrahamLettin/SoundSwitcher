using System.Windows;

namespace SoundSwitcher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly TrayIcon Icon;
        public App() => Icon = new();
        protected override void OnExit(ExitEventArgs e)
        {
            Icon.Dispose();
            base.OnExit(e);
        }
    }
}
