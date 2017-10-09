using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Interfaces;

namespace Mediateka.Classes
{
    class DiscTrack : Track, IDiscElement
    {
        public string Path { get; private set; }

        public DiscTrack(string name, string genre, string path) : base(name, genre)
        {
            Path = path;
        }
    }
}
