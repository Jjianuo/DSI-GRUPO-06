using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Playback;

namespace RADIANT_SPARK
{
    public class Manager
    {
        public Manager() { }
        ~Manager() { mediaPlayer.Dispose(); }
        public Dictionary<ActiveItem, int> CurrentBoughtItems { get; set; }

        public MediaPlayer mediaPlayer;

        public string lastPage;
    }
}
