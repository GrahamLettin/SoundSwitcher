using System;
using System.ComponentModel;
using System.Windows;

namespace SoundSwitcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CustomContextMenu : Window
    {
        private const double RelativeScreenSize = 0.25;

        public DelegateCommand ExitApplicationCommand { get; }
        public CustomContextMenu()
        {
            InitializeComponent();
            SetSize();
            DataContext = this;

            Closing += StopWindowClose;
            Deactivated += HideWhenLostFocus;

            //Set Commands (readonly so must be in constructor)
            ExitApplicationCommand = new DelegateCommand(ExitApplication);
        }

        private void HideWhenLostFocus(object? sender, EventArgs e) => Hide();

        private void StopWindowClose(object? sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void SetSize()
        {
            var desktopWorkingArea = SystemParameters.WorkArea;
            Height = SystemParameters.PrimaryScreenHeight * RelativeScreenSize;
            Width = SystemParameters.PrimaryScreenWidth * RelativeScreenSize;
            Left = desktopWorkingArea.Right - this.Width;
            Top = desktopWorkingArea.Bottom - this.Height;
        }
        private void ExitApplication(object? parameter) => Application.Current.Shutdown();
    }
}
