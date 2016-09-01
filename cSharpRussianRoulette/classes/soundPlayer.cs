using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace cSharpRussianRoulette.classes
{
   public class Player
    {
        public void soundPlayer(Stream s)
        {
           
          SoundPlayer mySoundPlayer = new SoundPlayer(s);
           
           mySoundPlayer.Play();      
            
        }
    }
}
