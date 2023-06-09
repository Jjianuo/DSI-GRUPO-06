﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
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
    public sealed partial class Shop : Page, INotifyPropertyChanged
    {
        string popupTitle;
        string popupText;
        string popupPrice;
        string moneyText;
        int money;
        ActiveItem lastClicked;
        Manager manager;
        public event PropertyChangedEventHandler PropertyChanged;
        public Shop()
        {
            this.InitializeComponent();
            this.ViewModel = new ActiveItemsViewModel();

            money = 70;
            if (ApplicationLanguages.PrimaryLanguageOverride == "en-US")
                moneyText = "Current credits: " + money.ToString() + "$";
            else if (ApplicationLanguages.PrimaryLanguageOverride == "es-ES")
                moneyText = "Dinero actual: " + money.ToString() + "€";
        }

        public ActiveItemsViewModel ViewModel { get; set; }

        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            var option = ((MenuFlyoutItem)sender).Tag.ToString();


            if (option == "alphabet")
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
        public interface INotifyPropertyChanged
        {
            event PropertyChangedEventHandler PropertyChanged;
        }

        private void mygridview_ItemClick(object sender, ItemClickEventArgs e)
        {
            manager.soundPlayer.Play();
            ActiveItem ai = e.ClickedItem as ActiveItem;
            lastClicked = ai;

            standardPopup.VerticalOffset = -200;
            standardPopup.HorizontalOffset = -200;
            popupTitle = ai.ItemName;
            popupText = ai.OneLineSummary;
            if (ApplicationLanguages.PrimaryLanguageOverride == "en-US")
                popupPrice = "Price: " + ai.Price.ToString() + "$";
            else if (ApplicationLanguages.PrimaryLanguageOverride == "es-ES")
                popupPrice = "Precio: " + ai.Price.ToString() + "€";

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(popupTitle)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(popupText)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(popupPrice)));
            standardPopup.IsOpen = !standardPopup.IsOpen;

            int newMoney = money - lastClicked.Price;
            if (newMoney < 0)
            {
                popupButton.IsEnabled = false;
                notEnoughPopup.Visibility = Visibility.Visible;
            }
            else
            {
                popupButton.Focus(FocusState.Programmatic);
                popupButton.IsEnabled = true;
                notEnoughPopup.Visibility = Visibility.Collapsed;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            manager.soundPlayer.Play();
            money -= lastClicked.Price;
            if (ApplicationLanguages.PrimaryLanguageOverride == "en-US")
                moneyText = "Current credits: " + money.ToString() + "$";
            else if (ApplicationLanguages.PrimaryLanguageOverride == "es-ES")
                moneyText = "Dinero actual: " + money.ToString() + "€";

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(moneyText)));
            manager.CurrentBoughtItems.Add(lastClicked);
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
            }
        }
    }
}
