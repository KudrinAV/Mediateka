using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Classes;
using Mediateka.Interfaces;
using System.Media;
using WMPLib;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Mediateka
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediateka myMediateka = new Mediateka();
            IMediaItem picture = new DiscPicture("first", "E:\\picture1.jpg");
            IMediaItem track = new DiscTrack("look what u made me do","pop", "E:\\track1.mp3");
            IMediaItem track2 = new DiscTrack("kek","book" ,"E:\\track1.wav");
            //myMediateka.Add(picture);
            myMediateka.Add(track2);
            myMediateka.Add(track2);
            foreach(var temp in myMediateka)
            {
                Console.WriteLine(temp.Name);
            }

            Player myPlayer = new Player(myMediateka);
            //WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
            //wplayer.URL = "E:\\track1.mp3";
            ////wplayer.controls.play();
            //SoundPlayer mySoundPlayer = new SoundPlayer();
            //mySoundPlayer.Stream = track2.MediaStream;
            //mySoundPlayer.PlaySync();
            Console.ReadKey();
            
        }
    }
}
