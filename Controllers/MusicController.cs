using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MemoryPoker.Controllers
{
    class MusicController
    {
        public void Answer()
        {
            Stream str = Resource.answer_voice;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
        }
        public void Wrong()
        {
            Stream str = Resource.wrong_voice;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
        }
    }
}
