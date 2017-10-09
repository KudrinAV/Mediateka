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
        public string Name { get; private set; }

        public TimeSpan Duration => throw new NotImplementedException();

        public string Genre { get; private set; }

        public Rating Rating => throw new NotImplementedException();

        public StreamReader MediaStream => throw new NotImplementedException();

        public long PhysicalSize => throw new NotImplementedException();

        public DateTime CreationTime => throw new NotImplementedException();

        public Track(string name, string genre) : base(name)
        {
            Name = name;
            Genre = genre;
        }
    }
}
