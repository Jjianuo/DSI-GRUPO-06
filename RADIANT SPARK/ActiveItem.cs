﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Globalization;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace RADIANT_SPARK
{
    public class ActiveItem
    {
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public int Price { get; set; }
        public string Icon { get; set; }
        public BitmapImage IconImg { get; set; }
        public ActiveItem()
        {
            this.ItemName = "Flamethrower";
            this.ItemType = "Equippable";
            this.Price = 10;
            this.Icon = "Assets/1.png";
            //string s = System.IO.Directory.GetCurrentDirectory() + "\\" + this.Icon;
            this.IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/1.png"));
        }
        public string OneLineSummary
        {
            get
            {
                if (ApplicationLanguages.PrimaryLanguageOverride == "en-US")
                    return $"{this.ItemName} is a {this.ItemType} item";
                else if (ApplicationLanguages.PrimaryLanguageOverride == "es-ES")
                    return $"{this.ItemName} es un objeto {this.ItemType}.";
                else return " ";
            }
        }
    }
    public class ActiveItemsViewModel
    {
        private ActiveItem defaultActiveItem = new ActiveItem();
        public ActiveItem DefaultActiveItem { get { return this.defaultActiveItem; } }

        private ObservableCollection<ActiveItem> activeitems = new ObservableCollection<ActiveItem>();
        public ObservableCollection<ActiveItem> Activeitems { get { return this.activeitems; } }
        public ActiveItemsViewModel()
        {
            if (ApplicationLanguages.PrimaryLanguageOverride == "en-US")
            {
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Bucket",
                    ItemType = "Equippable",
                    Price = 92,
                    Icon = "Assets/1.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/1.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Earthquake",
                    ItemType = "Terrain",
                    Price = 10,
                    Icon = "Assets/2.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/2.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "HP potion",
                    ItemType = "Consumable",
                    Price = 7,
                    Icon = "Assets/3.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/3.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "HP boost",
                    ItemType = "Consumable",
                    Price = 56,
                    Icon = "Assets/4.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/4.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Bird",
                    ItemType = "Summon",
                    Price = 36,
                    Icon = "Assets/5.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/5.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Bear",
                    ItemType = "Summon",
                    Price = 75,
                    Icon = "Assets/6.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/6.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Bottle",
                    ItemType = "Consumable",
                    Price = 81,
                    Icon = "Assets/7.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/7.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Lollipop",
                    ItemType = "Consumable",
                    Price = 46,
                    Icon = "Assets/8.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/8.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Cat",
                    ItemType = "Summon",
                    Price = 60,
                    Icon = "Assets/9.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/9.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Mythic sword",
                    ItemType = "Equippable",
                    Price = 38,
                    Icon = "Assets/10.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/10.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Laptop",
                    ItemType = "Equippable",
                    Price = 16,
                    Icon = "Assets/11.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/11.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Holy water",
                    ItemType = "Consumable",
                    Price = 9,
                    Icon = "Assets/12.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/12.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "S8nic bible",
                    ItemType = "Consumable",
                    Price = 686,
                    Icon = "Assets/13.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/13.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Archangel's halo",
                    ItemType = "Consumable",
                    Price = 7,
                    Icon = "Assets/14.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/14.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Orca",
                    ItemType = "Summon",
                    Price = 16,
                    Icon = "Assets/15.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/15.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "AK-47",
                    ItemType = "Equippable",
                    Price = 47,
                    Icon = "Assets/16.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/16.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Balls",
                    ItemType = "Summon",
                    Price = 69,
                    Icon = "Assets/17.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/17.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "OPPA",
                    ItemType = "Summon",
                    Price = 369,
                    Icon = "Assets/18.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/18.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "i-phone 2394",
                    ItemType = "Consumable",
                    Price = 999999999,
                    Icon = "Assets/19.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/19.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Die",
                    ItemType = "Consumable",
                    Price = -5,
                    Icon = "Assets/20.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/20.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Batchest",
                    ItemType = "Summon",
                    Price = 2120,
                    Icon = "Assets/21.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/21.png"))
                });
            }
            else if (ApplicationLanguages.PrimaryLanguageOverride == "es-ES")
            {
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Cubo",
                    ItemType = "Equipable",
                    Price = 92,
                    Icon = "Assets/1.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/1.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Terremoto",
                    ItemType = "Terreno",
                    Price = 10,
                    Icon = "Assets/2.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/2.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Poción HP",
                    ItemType = "Consumible",
                    Price = 7,
                    Icon = "Assets/3.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/3.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Aumento de HP",
                    ItemType = "Consumible",
                    Price = 56,
                    Icon = "Assets/4.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/4.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Pájaro",
                    ItemType = "Invocable",
                    Price = 36,
                    Icon = "Assets/5.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/5.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Oso",
                    ItemType = "Invocable",
                    Price = 75,
                    Icon = "Assets/6.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/6.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Botella",
                    ItemType = "Consumible",
                    Price = 81,
                    Icon = "Assets/7.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/7.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Piruleta",
                    ItemType = "Consumible",
                    Price = 46,
                    Icon = "Assets/8.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/8.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Gato",
                    ItemType = "Invocable",
                    Price = 60,
                    Icon = "Assets/9.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/9.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Espada Mítica",
                    ItemType = "Equipable",
                    Price = 38,
                    Icon = "Assets/10.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/10.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Portátil",
                    ItemType = "Equipable",
                    Price = 16,
                    Icon = "Assets/11.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/11.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Agua Bendita",
                    ItemType = "Consumible",
                    Price = 9,
                    Icon = "Assets/12.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/12.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Biblia Sospechosa",
                    ItemType = "Consumible",
                    Price = 686,
                    Icon = "Assets/13.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/13.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Halo de Archangel",
                    ItemType = "Consumible",
                    Price = 7,
                    Icon = "Assets/14.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/14.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Orca",
                    ItemType = "Invocable",
                    Price = 16,
                    Icon = "Assets/15.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/15.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "AK-47",
                    ItemType = "Equipable",
                    Price = 47,
                    Icon = "Assets/16.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/16.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Balls",
                    ItemType = "Invocable",
                    Price = 69,
                    Icon = "Assets/17.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/17.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "OPPA",
                    ItemType = "Invocable",
                    Price = 369,
                    Icon = "Assets/18.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/18.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "i-phone 2394",
                    ItemType = "Consumible",
                    Price = 999999999,
                    Icon = "Assets/19.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/19.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Muerte",
                    ItemType = "Consumible",
                    Price = -5,
                    Icon = "Assets/20.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/20.png"))
                });
                this.activeitems.Add(new ActiveItem()
                {
                    ItemName = "Batchest",
                    ItemType = "Invocable",
                    Price = 2120,
                    Icon = "Assets/21.png",
                    IconImg = new BitmapImage(new Uri(@"ms-appx:///Assets/21.png"))
                });
            }
        }
    }
}

