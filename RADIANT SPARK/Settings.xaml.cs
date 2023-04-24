﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Globalization;
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
        CurrentItems currentItems;
        public List<string> Resolutions { get; } = new List<string>()
        {
            "2160x1440",
            "1920x1080",
            "1280x720"
        };
        public List<string> Languages { get; } = new List<string>()
        {
            "Spanish",
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
                ElementSoundPlayer.Volume = slider.Value / 100;
            }
        }

        private void SoundSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {

        }

        private void Back_click(object sender, RoutedEventArgs e)
        {
            App.TryGoBack();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e?.Parameter is CurrentItems ci)
            {
                currentItems = ci;
            }
        }

        private void Language_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string language = e.AddedItems[0].ToString();
            switch(language)
            {
                case "Spanish":
                    ApplicationLanguages.PrimaryLanguageOverride = "Spanish";
                    break;
                case "English":
                    ApplicationLanguages.PrimaryLanguageOverride = "English";
                    break;
            }
        }
    }
}
