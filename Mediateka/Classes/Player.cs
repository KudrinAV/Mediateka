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

        public Player(ICollection<IMediaItem> items)
        {
            foreach(IMediaItem item in items)
            {

                Console.ReadLine();
            }

        }

        public Player(ICollection<IDiscElement> items)
        {
            foreach(IDiscElement item in items)
            {
                myMediaPlayer.Open(item.Path);
                myMediaPlayer.Play();
                Console.ReadLine();
            }
        }

        public Player(IPlayList playList)
        {

        }
    }
}
