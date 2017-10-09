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
        public string Name { get; private set; }

        public Size Size => throw new NotImplementedException();

        public Rating Rating => throw new NotImplementedException();

        public FileStream MediaStream => throw new NotImplementedException();

        public long PhysicalSize => throw new NotImplementedException();

        public DateTime CreationTime => throw new NotImplementedException();

        public Picture(string name) : base(name)
        {
            Name = name;
        }
    }
}
