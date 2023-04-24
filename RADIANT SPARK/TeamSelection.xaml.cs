﻿using System;
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
        CurrentItems currentItems;
        public TeamSelection()
        {
            this.InitializeComponent();
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

        private void Oldworld_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MapSelection), currentItems);
        }

        private void Newworld_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CharacterSelection), currentItems);
        }
    }
}
