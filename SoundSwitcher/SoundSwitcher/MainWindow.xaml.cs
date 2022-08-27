using System.Windows;

namespace SoundSwitcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CustomContextMenu : Window
    {
        private const double RelativeScreenSize = 0.25;

        public CustomContextMenu()
        {
            InitializeComponent();
            var desktopWorkingArea = SystemParameters.WorkArea;
            Height = (SystemParameters.PrimaryScreenHeight * RelativeScreenSize);
            Width = (SystemParameters.PrimaryScreenWidth * RelativeScreenSize);
            Left = desktopWorkingArea.Right - this.Width;
            Top = desktopWorkingArea.Bottom - this.Height; 
        }
    }
}
