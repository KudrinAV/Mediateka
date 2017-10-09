using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Interfaces;
using System.IO;

namespace Mediateka.Classes
{
    public class WebTrack : Track, IWebElement
    {
        public string URL { get; private set; }

        public WebTrack(string name,string genre ,string url) : base(name, genre)
        {
            URL = url;
            MediaStream = File.OpenRead(url);
            CreationTime = File.GetCreationTime(url);
        }

        //public FileStream GetFileStream()
        //{
        //    return MediaStream = File.OpenRead(URL);
        //}

    }
}
