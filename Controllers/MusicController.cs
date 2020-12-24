using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace MemoryPoker.Controllers
{
    class MusicController
    {
        public void answer()
        {
            WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
            wplayer.URL = "Resource/answer_voice.wav";
            wplayer.controls.play();
        }
        public void wrong()
        {
            WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
            wplayer.URL = "Resource/wrong_voice.wav";
            wplayer.controls.play();
        }
    }
}
