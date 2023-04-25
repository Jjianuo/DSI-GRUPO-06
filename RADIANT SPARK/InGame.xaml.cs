using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace RADIANT_SPARK
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class InGame : Page
    {
        Manager manager;
        public Dictionary<ActiveItem, int> items { get; } = new Dictionary<ActiveItem, int>();
        public InGame()
        {
            this.InitializeComponent();
            this.ViewModel = new ActiveItemsViewModel();
        }
        public ActiveItemsViewModel ViewModel { get; set; }
        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            manager.soundPlayer.Play();
            Frame.Navigate(typeof(PauseMenu), manager);
        }
        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            manager.soundPlayer.Play();
            Frame.Navigate(typeof(Settings), manager);
        }

        private void Canvas_DragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.Copy;
        }

        private void Canvas_Drop(object sender, DragEventArgs e)
        {
            ActiveItem Item = e.OriginalSource as ActiveItem;
            string id = Item.Icon.ToString();

            var img = new Image();
            img.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(id));

            img.Width = 100;
            img.Height = 100;
            MiCanvas.Children.Add(img);
            Point PD = e.GetPosition(MiCanvas);
            img.SetValue(Canvas.LeftProperty, PD.X);
            img.SetValue(Canvas.TopProperty, PD.Y);
        }

        private void Button_DragStarting(UIElement sender, DragStartingEventArgs args)
        {
            ActiveItem Item = args.OriginalSource as ActiveItem;
            string id = Item.Icon.ToString();
            args.Data.SetText(id);
            args.Data.RequestedOperation = DataPackageOperation.Copy;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e?.Parameter is Manager ci)
            {
                manager = ci;
                manager.lastPage = "InGame";
            }

            // Cosntruye las listas de ModelView a partir de la listaModelo 
            if (manager.CurrentBoughtItems != null)
                foreach (KeyValuePair<ActiveItem, int> boughtItem in manager.CurrentBoughtItems)
                {
                    this.items.Add(boughtItem.Key, boughtItem.Value);
                }
            base.OnNavigatedTo(e);
        }
    }
}
