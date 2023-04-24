using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RADIANT_SPARK
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Manager manager;

        public MainPage()
        {
            this.InitializeComponent();
            if(manager == null)
            {
                manager = new Manager();
                manager.CurrentBoughtItems = new Dictionary<ActiveItem, int>();

                manager.mediaPlayer = new MediaPlayer();
                manager.mediaPlayer.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Sound/menu.wav"));
                manager.mediaPlayer.Volume = 0.5;
                manager.mediaPlayer.IsLoopingEnabled = true;
                manager.mediaPlayer.Play();
            }
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ChooseGame), manager);
        }
        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Settings), manager);
        }
        private void Shop_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Shop), manager);
        }
        private void Credits_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Credits), manager);
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        } 

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if(e?.Parameter is Manager ci)
            {
                manager = ci;
                manager.lastPage = "MainPage";
            }
        }
    }
}
