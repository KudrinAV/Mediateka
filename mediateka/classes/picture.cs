using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Interfaces;

namespace Mediateka.Classes
{
    public class Picture : MediaItem, IPicture
    {
       // public string Name { get; private set; }

        public Size Size { get; protected set; }

        public Rating Rating { get; protected set; }

        public FileStream MediaStream { get; protected set; }

        public long PhysicalSize { get; }

        public DateTime CreationTime { get; protected set; }

        public bool AmITrack { get; }

        public Picture(string name) : base(name)
        {
            //Name = name;
            AmITrack = false;
        }
    }
}
