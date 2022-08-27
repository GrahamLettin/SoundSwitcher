using System.Drawing;

namespace SoundSwitcher.Models
{
    internal class AudioDevice
    {
        public int ID { get; set; }
        public string Description { get; set; } = string.Empty;
        public Image Icon { get; set; }
        public int Volume { get; set; }
    }
}
