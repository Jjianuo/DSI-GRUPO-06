using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace RADIANT_SPARK
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Settings : Page
    {
        public List<string> Resolutions { get; } = new List<string>()
        {
            "2160x1440",
            "1920x1080",
            "1280x720"
        };
        public List<string> Languages { get; } = new List<string>()
        {
            "Español",
            "English"
        };

        public Settings()
        {
            this.InitializeComponent();
        }

        private void MusicSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            Slider slider = sender as Slider;
            if (slider != null)
            {
                //media.Volume = slider.Value;
            }
        }

        private void SoundSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            App.TryGoBack();
        }
    }
}
