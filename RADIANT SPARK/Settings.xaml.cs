using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Resources.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Globalization;
using Windows.UI.ViewManagement;
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
    public sealed partial class Settings : Page, INotifyPropertyChanged
    {
        Manager manager;
        public double musicValue;
        public double soundValue;
        public event PropertyChangedEventHandler PropertyChanged;
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
            if (slider != null && manager != null)
            {
                manager.slidePlayer.Play();
                musicValue = slider.Value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(musicValue)));
                manager.mediaPlayer.Volume = musicValue / 100;
            }
        }

        private void SoundSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            Slider slider = sender as Slider;
            if (slider != null && manager != null)
            {
                manager.slidePlayer.Play();
                soundValue = slider.Value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(soundValue)));
                manager.slidePlayer.Volume = soundValue / 100;
                manager.soundPlayer.Volume = soundValue / 100;
            }
        }

        private void Back_click(object sender, RoutedEventArgs e)
        {
            manager.soundPlayer.Play();
            if (manager.lastPage == "InGame")
                Frame.Navigate(typeof(InGame), manager);
            else if (manager.lastPage == "PauseMenu")
                Frame.Navigate(typeof(PauseMenu), manager);
            else
                Frame.Navigate(typeof(MainPage), manager);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e?.Parameter is Manager ci)
            {
                manager = ci;
                musicValue = manager.mediaPlayer.Volume * 100;
                soundValue = manager.soundPlayer.Volume * 100;
                if (manager.language == "en-US")
                    LanguageCombobox.SelectedItem = "English";
                else
                    LanguageCombobox.SelectedItem = "Spanish";
                if (ApplicationView.PreferredLaunchWindowingMode == ApplicationViewWindowingMode.FullScreen)
                    Fullscreen.IsChecked = true;
                else
                    Fullscreen.IsChecked = false;
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            var view = ApplicationView.GetForCurrentView();

            if (view.TryEnterFullScreenMode())
            {
                ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen;
            }
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            var view = ApplicationView.GetForCurrentView();

            view.ExitFullScreenMode();
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.Auto;
        }

        private void Language_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string language = e.AddedItems[0].ToString();
            switch (language)
            {
                case "English":
                    ApplicationLanguages.PrimaryLanguageOverride = "en-US";
                    if (manager != null)
                        manager.language = "en-US";
                    break;
                case "Spanish":
                    ApplicationLanguages.PrimaryLanguageOverride = "es-ES";
                    if(manager != null)
                        manager.language = "es-ES";
                    break;
            }
        }
    }
}
