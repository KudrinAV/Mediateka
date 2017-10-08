using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Interfaces;

namespace Mediateka.Classes
{
    public class WebTrack : Track, IWebElement
    {
        public string URL { get; private set; }

        public WebTrack(string name, string url) : base(name)
        {
            URL = url;
        }

    }
}
