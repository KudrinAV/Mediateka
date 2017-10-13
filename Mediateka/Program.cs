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
            IMediaItem track1 = new DiscTrack("look what u made me do","pop", "E:\\track1.mp3");
            IMediaItem track2 = new DiscTrack("kek","book" ,"E:\\track2.wav");
            IMediaItem track3 = new DiscTrack("test", "rock", "E:\\track2.wav");

            myMediateka.Add(picture);
            myMediateka.Add(track1);
            myMediateka.Add(track2);
            myMediateka.Add(track3);

            Player myPlayer = new Player(myMediateka);
            Console.ReadKey();
            
        }
    }
}
