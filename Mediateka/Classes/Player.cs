using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Classes;
using Mediateka.Interfaces;

namespace Mediateka.Classes
{
    public class Player
    {
        MediaPlayer.MediaPlayer myMediaPlayer = new MediaPlayer.MediaPlayer();

        public Player(ICollection<IWebElement> items)
        {
            foreach(IWebElement item in items)
            {
                myMediaPlayer.Open(item.URL);
                myMediaPlayer.Play();
                Console.ReadLine();
            }

        }
    }
}
