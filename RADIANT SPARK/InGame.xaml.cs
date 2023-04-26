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
        public ObservableCollection<ActiveItem> listaItems { get; } = new ObservableCollection<ActiveItem>();
        public List<ActiveItem> items { get; } = new List<ActiveItem>();
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

        private async void Canvas_Drop(object sender, DragEventArgs e)
        {
            var id = await e.DataView.GetTextAsync();
            var num = int.Parse(id);

            ActiveItem Item = listaItems[num];

            var img = new Image();
            img.Source = Item.IconImg;

            img.Width = 100;
            img.Height = 100;
            MiCanvas.Children.Add(img);
            Point PD = e.GetPosition(MiCanvas);
            img.SetValue(Canvas.LeftProperty, PD.X);
            img.SetValue(Canvas.TopProperty, PD.Y);
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
                foreach (ActiveItem boughtItem in manager.CurrentBoughtItems)
                {
                    this.items.Add(boughtItem);
                }
            base.OnNavigatedTo(e);
        }

        private void ListView_DragItemsStarting(object sender, DragItemsStartingEventArgs e)
        {
            ActiveItem Item = e.Items[0]  as ActiveItem;
            int id = Item.Id;
            e.Data.SetText(id.ToString());
            e.Data.RequestedOperation = DataPackageOperation.Copy;
        }
    }
}
