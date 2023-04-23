using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RADIANT_SPARK
{
    public class CurrentItems
    {
        public CurrentItems() { }
        public Dictionary<ActiveItem, int> CurrentBoughtItems { get; set; }
    }
}
