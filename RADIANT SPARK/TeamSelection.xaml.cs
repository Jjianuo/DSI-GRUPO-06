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
    public sealed partial class TeamSelection : Page
    {
        Manager manager;
        public TeamSelection()
        {
            this.InitializeComponent();
        }

        private void Back_click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Story), manager);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e?.Parameter is Manager ci)
            {
                manager = ci;
                manager.lastPage = "TeamSelection";
            }
        }

        private void Oldworld_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MapSelection), manager);
        }

        private void Newworld_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CharacterSelection), manager);
        }
    }
}
