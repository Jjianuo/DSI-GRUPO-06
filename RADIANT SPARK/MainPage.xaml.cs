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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RADIANT_SPARK
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        CurrentItems currentItems;
        public MainPage()
        {
            this.InitializeComponent();
            currentItems = new CurrentItems();
            currentItems.CurrentBoughtItems = new Dictionary<ActiveItem, int>();
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ChooseGame), currentItems);
        }
        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Settings), currentItems);
        }
        private void Shop_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Shop), currentItems);
        }
        private void Credits_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Credits), currentItems);
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        } 

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if(e?.Parameter is CurrentItems ci)
            {
                currentItems = ci;
            }
        }
    }
}
