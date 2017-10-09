using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Classes;
using Mediateka.Interfaces;

namespace Mediateka
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediateka myMediateka = new Mediateka();
            IMediaItem picture = new DiscPicture("first", "E:\\picture1.jpg");
            IMediaItem track = new DiscTrack("look what u made me do","pop", "E:\\track1.mp3");
            myMediateka.Add(picture);
            myMediateka.Add(track);
            myMediateka.Add(track);
            foreach(var temp in myMediateka)
            {
                Console.WriteLine(temp.Name);
            }
            MediaPlayer.MediaPlayer myMediaPlayer = new MediaPlayer.MediaPlayer();
            foreach(IDiscElement item in myMediateka)
            {
                myMediaPlayer.Open(item.Path);
                myMediaPlayer.Play();
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
