using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Interfaces;
using System.IO;

namespace Mediateka.Classes
{
    class DiscTrack : Track, IDiscElement
    {
        public string Path { get; private set; }

        public DiscTrack(string name, string genre, string path) : base(name, genre)
        {
            Path = path;
            MediaStream = File.OpenRead(path);
            CreationTime = File.GetCreationTime(path);
        }

        //public FileStream GetFileStream()
        //{
        //    return MediaStream = File.OpenRead(Path);
        //}
    }
}
