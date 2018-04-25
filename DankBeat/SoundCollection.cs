using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DankBeat
{
    class SoundCollection
    {
        public SoundCollection()
        {
            GenerateSounds();
        }

        private List<Sound> _sounds;
        public List<Sound> Sounds => _sounds;

        void GenerateSounds()
        {
            _sounds = new List<Sound>();
            var snare = new MediaElement
            {
                Source = new Uri("./sounds/clap.wma", UriKind.Relative),
                LoadedBehavior = MediaState.Manual
            };
            var Snare = new Sound
            {
                SoundName = "Snare",
                CanRepeat = false,
                RepeatRate = 1000,
                Media = snare
            };
            _sounds.Add(Snare);
        }
    }
}
