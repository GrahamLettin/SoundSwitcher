using SoundSwitcher.Models;
using System;
using System.Drawing;

namespace SoundSwitcher.ViewModels
{
    internal class SoundControlViewModel
    {
        public AudioDevice[] AudioDevices { get; set; } = Array.Empty<AudioDevice>();
        public SoundControlViewModel()
        {
            AudioDevices = new[] {
                new AudioDevice { ID = 1, Description = "Test 1", Volume = 90 },
                new AudioDevice { ID = 2, Description = "Test 2", Volume = 47 },
                new AudioDevice { ID = 3, Description = "Test 3", Volume = 30 },
                new AudioDevice { ID = 4, Description = "Test 4", Volume = 20 },
                new AudioDevice { ID = 5, Description = "Test 5", Volume = 75 }
            };
        }
    }
}
