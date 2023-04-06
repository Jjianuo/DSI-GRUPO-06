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
        public string ArtistName { get; set; }
        public string CompositionName { get; set; }
        public DateTime ReleaseDateTime { get; set; }
        public ActiveItem()
        {
            this.ArtistName = "Wolfgang Amadeus Mozart";
            this.CompositionName = "Andante in C for Piano";
            this.ReleaseDateTime = new DateTime(1761, 1, 1);
        }
        public string OneLineSummary
        {
            get
            {
                return $"{this.CompositionName} by {this.ArtistName}, released: "
                    + this.ReleaseDateTime.ToString("d");
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
                ArtistName = "Johann Sebastian Bach",
                CompositionName = "Mass in B minor",
                ReleaseDateTime = new DateTime(1748, 7, 8)
            });
            this.activeitems.Add(new ActiveItem()
            {
                ArtistName = "Ludwig van Beethoven",
                CompositionName = "Third Symphony",
                ReleaseDateTime = new DateTime(1805, 2, 11)
            });
            this.activeitems.Add(new ActiveItem()
            {
                ArtistName = "George Frideric Handel",
                CompositionName = "Serse",
                ReleaseDateTime = new DateTime(1737, 12, 3)
            });
            this.activeitems.Add(new ActiveItem()
            {
                ArtistName = "George Frideric Handel",
                CompositionName = "Serse",
                ReleaseDateTime = new DateTime(1737, 12, 3)
            });
            this.activeitems.Add(new ActiveItem()
            {
                ArtistName = "George Frideric Handel",
                CompositionName = "Serse",
                ReleaseDateTime = new DateTime(1737, 12, 3)
            });
            this.activeitems.Add(new ActiveItem()
            {
                ArtistName = "George Frideric Handel",
                CompositionName = "Serse",
                ReleaseDateTime = new DateTime(1737, 12, 3)
            });
            this.activeitems.Add(new ActiveItem()
            {
                ArtistName = "George Frideric Handel",
                CompositionName = "Serse",
                ReleaseDateTime = new DateTime(1737, 12, 3)
            });
            this.activeitems.Add(new ActiveItem()
            {
                ArtistName = "George Frideric Handel",
                CompositionName = "Serse",
                ReleaseDateTime = new DateTime(1737, 12, 3)
            });
            this.activeitems.Add(new ActiveItem()
            {
                ArtistName = "George Frideric Handel",
                CompositionName = "Serse",
                ReleaseDateTime = new DateTime(1737, 12, 3)
            });
            this.activeitems.Add(new ActiveItem()
            {
                ArtistName = "George Frideric Handel",
                CompositionName = "Serse",
                ReleaseDateTime = new DateTime(1737, 12, 3)
            });
            this.activeitems.Add(new ActiveItem()
            {
                ArtistName = "George Frideric Handel",
                CompositionName = "Serse",
                ReleaseDateTime = new DateTime(1737, 12, 3)
            });
            this.activeitems.Add(new ActiveItem()
            {
                ArtistName = "George Frideric Handel",
                CompositionName = "Serse",
                ReleaseDateTime = new DateTime(1737, 12, 3)
            });
            this.activeitems.Add(new ActiveItem()
            {
                ArtistName = "George Frideric Handel",
                CompositionName = "Serse",
                ReleaseDateTime = new DateTime(1737, 12, 3)
            });
            this.activeitems.Add(new ActiveItem()
            {
                ArtistName = "George Frideric Handel",
                CompositionName = "Serse",
                ReleaseDateTime = new DateTime(1737, 12, 3)
            });
            this.activeitems.Add(new ActiveItem()
            {
                ArtistName = "George Frideric Handel",
                CompositionName = "Serse",
                ReleaseDateTime = new DateTime(1737, 12, 3)
            });
            this.activeitems.Add(new ActiveItem()
            {
                ArtistName = "George Frideric Handel",
                CompositionName = "Serse",
                ReleaseDateTime = new DateTime(1737, 12, 3)
            });
            this.activeitems.Add(new ActiveItem()
            {
                ArtistName = "George Frideric Handel",
                CompositionName = "Serse",
                ReleaseDateTime = new DateTime(1737, 12, 3)
            });
            this.activeitems.Add(new ActiveItem()
            {
                ArtistName = "George Frideric Handel",
                CompositionName = "Serse",
                ReleaseDateTime = new DateTime(1737, 12, 3)
            });
            this.activeitems.Add(new ActiveItem()
            {
                ArtistName = "George Frideric Handel",
                CompositionName = "Serse",
                ReleaseDateTime = new DateTime(1737, 12, 3)
            });
            this.activeitems.Add(new ActiveItem()
            {
                ArtistName = "George Frideric Handel",
                CompositionName = "Serse",
                ReleaseDateTime = new DateTime(1737, 12, 3)
            });
            this.activeitems.Add(new ActiveItem()
            {
                ArtistName = "George Frideric Handel",
                CompositionName = "Serse",
                ReleaseDateTime = new DateTime(1737, 12, 3)
            });
        }
    }
}

