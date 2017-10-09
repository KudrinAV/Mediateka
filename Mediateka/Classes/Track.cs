using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Interfaces;

namespace Mediateka.Classes
{
    public class Track : MediaItem, ITrack
    {
        //public string Name { get; private set; }

        public TimeSpan Duration { get; }

        public string Genre { get; private set; }

        public Rating Rating { get; private set }

        public FileStream MediaStream { get; protected set; }

        public long PhysicalSize { get; }

        public DateTime CreationTime { get; protected set; }

        public Track(string name, string genre) : base(name)
        {
            //Name = name;
            Genre = genre;
        }
    }
}
