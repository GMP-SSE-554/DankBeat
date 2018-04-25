using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DankBeat
{
    class Sound : BindableBase
    {
        private string _soundName;
        public string SoundName
        {
            get { return _soundName; }
            set
            {
                SetProperty(ref _soundName, value);
            }
        }

        private bool _canRepeat;
        public bool CanRepeat
        {
            get { return _canRepeat; }
            set
            {
                SetProperty(ref _canRepeat, value);
            }
        }

        private int _repeatRate;
        public int RepeatRate
        {
            get { return _repeatRate; }
            set
            {
                SetProperty(ref _repeatRate, value);
            }
        }

        private MediaElement _media;
        public MediaElement Media
        {
            get { return _media; }
            set
            {
                SetProperty(ref _media, value);
            }
        }
    }
}
