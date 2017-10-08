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
            IMediaItem picture = new WebPicture("first", "networld");
            IMediaItem track = new DiscTrack("look what u made me do","pop", "U SHALL NO PATH");
            myMediateka.Add(picture);
            myMediateka.Add(track);
            foreach(var temp in myMediateka)
            {
                Console.WriteLine(temp.Name);
            }
        }
    }
}
