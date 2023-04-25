using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Globalization;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.UI.Xaml.Controls;

namespace RADIANT_SPARK
{
    public class Manager
    {
        public Dictionary<ActiveItem, int> CurrentBoughtItems { get; set; }

        public MediaPlayer mediaPlayer;
        public MediaPlayer soundPlayer;
        public MediaPlayer slidePlayer;
        MediaSource _BGMSource;
        MediaSource _clickSource;
        MediaSource _slideSource;
        MediaPlaybackItem BGMSound;
        MediaPlaybackItem clickSound;
        MediaPlaybackItem slideSound;

        public string lastPage;
        public string language;

        public Manager() {
            CurrentBoughtItems = new Dictionary<ActiveItem, int>();

            _clickSource = MediaSource.CreateFromUri(new Uri("ms-appx:///Sound/Click.wav"));
            _slideSource = MediaSource.CreateFromUri(new Uri("ms-appx:///Sound/Bleep_07.wav"));
            _BGMSource = MediaSource.CreateFromUri(new Uri("ms-appx:///Sound/menu.wav"));
            clickSound = new MediaPlaybackItem(_clickSource);
            slideSound = new MediaPlaybackItem(_slideSource);
            BGMSound = new MediaPlaybackItem(_BGMSource);

            soundPlayer = new MediaPlayer();
            soundPlayer.Source = clickSound;
            soundPlayer.Volume = 0.5;

            slidePlayer = new MediaPlayer();
            slidePlayer.Source = slideSound;
            slidePlayer.Volume = 0.5;

            mediaPlayer = new MediaPlayer();
            mediaPlayer.Source = BGMSound;
            mediaPlayer.Volume = 0.5;
            mediaPlayer.IsLoopingEnabled = true;
            mediaPlayer.Play();

            language = ApplicationLanguages.PrimaryLanguageOverride;
        }
        ~Manager() { 
            mediaPlayer.Dispose(); 
            soundPlayer.Dispose();
            slidePlayer.Dispose();
        }

    }
}
