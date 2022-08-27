using SoundSwitcher.Services;
using System.Windows;

namespace SoundSwitcher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly TrayIconService IconService;
        public App() => IconService = new();
        protected override void OnExit(ExitEventArgs e)
        {
            IconService.Stop();
            base.OnExit(e);
        }
    }
}
