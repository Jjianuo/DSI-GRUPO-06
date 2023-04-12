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
    public sealed partial class Shop : Page
    {
        public Shop()
        {
            this.InitializeComponent();
            this.ViewModel = new ActiveItemsViewModel();
        }

        public ActiveItemsViewModel ViewModel { get; set; }

        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            var option = ((MenuFlyoutItem)sender).Tag.ToString();

            if (option == "all")
            {
                var SortResult = this.ViewModel.Activeitems.OrderBy(a => a.ItemName);
                mygridview.ItemsSource = SortResult;
            }
            else if (option == "alphabet")
            {
                var SortResult = this.ViewModel.Activeitems.OrderBy(a => a.ItemName);
                mygridview.ItemsSource = SortResult;

            }
            else if (option == "type")
            {
                var SortResult = this.ViewModel.Activeitems.OrderBy(a => a.ItemType);
                mygridview.ItemsSource = SortResult;

            }
            else if (option == "price")
            {
                var SortResult = this.ViewModel.Activeitems.OrderBy(a => a.Price);
                mygridview.ItemsSource = SortResult;

            }
        }
    }
}
