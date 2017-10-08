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
    class Picture : IPicture
    {
        public Size Size => throw new NotImplementedException();

        public Rating Rating => throw new NotImplementedException();

        public StreamReader MediaStream => throw new NotImplementedException();

        public long PhysicalSize => throw new NotImplementedException();

        public DateTime CreationTime => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();
    }
}
