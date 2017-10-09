using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Interfaces;

namespace Mediateka.Classes
{
    class DiscPicture : Picture, IDiscElement
    {
        public string Path { get; private set; }

        public DiscPicture(string name, string path) : base(name)
        {
            Path = path;
        }
    }
}
