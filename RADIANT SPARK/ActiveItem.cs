using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RADIANT_SPARK
{
    public class ActiveItem
    {
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public int Price { get; set; }
        public ActiveItem()
        {
            this.ItemName = "Flamethrower";
            this.ItemType = "Equippable";
            this.Price = 10;
        }
        public string OneLineSummary
        {
            get
            {
                return $"{this.ItemType}, {this.ItemName}";
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
            this.activeitems.Add(new ActiveItem()
            {
                ItemName = "Bucket",
                ItemType = "Equippable",
                Price = 92
            });
            this.activeitems.Add(new ActiveItem()
            {
                ItemName = "Earthquake",
                ItemType = "Terrain",
                Price = 10
            });
            this.activeitems.Add(new ActiveItem()
            {
                ItemName = "HP potion",
                ItemType = "Consumable",
                Price = 7
            });
            this.activeitems.Add(new ActiveItem()
            {
                ItemName = "HP boost",
                ItemType = "Consumable",
                Price = 56
            });
            this.activeitems.Add(new ActiveItem()
            {
                ItemName = "Bird",
                ItemType = "Summon",
                Price = 36
            });
            this.activeitems.Add(new ActiveItem()
            {
                ItemName = "Bear",
                ItemType = "Summon",
                Price = 75
            });
            this.activeitems.Add(new ActiveItem()
            {
                ItemName = "Bottle",
                ItemType = "Consumable",
                Price = 81
            });
            this.activeitems.Add(new ActiveItem()
            {
                ItemName = "Lollipop",
                ItemType = "Consumable",
                Price = 46
            });
            this.activeitems.Add(new ActiveItem()
            {
                ItemName = "Cat",
                ItemType = "Summon",
                Price = 60
            });
            this.activeitems.Add(new ActiveItem()
            {
                ItemName = "Mythic sword",
                ItemType = "Equippable",
                Price = 38
            });
            this.activeitems.Add(new ActiveItem()
            {
                ItemName = "Laptop",
                ItemType = "Equippable",
                Price = 16
            });
            this.activeitems.Add(new ActiveItem()
            {
                ItemName = "Holy water",
                ItemType = "Consumable",
                Price = 9
            });
            this.activeitems.Add(new ActiveItem()
            {
                ItemName = "S8nic bible",
                ItemType = "Consumable",
                Price = 686
            });
            this.activeitems.Add(new ActiveItem()
            {
                ItemName = "Archangel's halo",
                ItemType = "Consumable",
                Price = 7
            });
            this.activeitems.Add(new ActiveItem()
            {
                ItemName = "Orca",
                ItemType = "Summon",
                Price = 16
            });
            this.activeitems.Add(new ActiveItem()
            {
                ItemName = "George Frideric Handel",
                ItemType = "Serse",
                Price = 9
            });
            this.activeitems.Add(new ActiveItem()
            {
                ItemName = "George Frideric Handel",
                ItemType = "Serse",
                Price = 9
            });
            this.activeitems.Add(new ActiveItem()
            {
                ItemName = "George Frideric Handel",
                ItemType = "Serse",
                Price = 9
            });
            this.activeitems.Add(new ActiveItem()
            {
                ItemName = "George Frideric Handel",
                ItemType = "Serse",
                Price = 9
            });
            this.activeitems.Add(new ActiveItem()
            {
                ItemName = "George Frideric Handel",
                ItemType = "Serse",
                Price = 9
            });
            this.activeitems.Add(new ActiveItem()
            {
                ItemName = "George Frideric Handel",
                ItemType = "Serse",
                Price = 9
            });
        }
    }
}

