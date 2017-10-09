﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Interfaces;

namespace Mediateka.Classes
{
    public class WebPicture : Picture, IWebElement
    {
        public string URL { get; private set; }

        public WebPicture(string name, string url) : base(name)
        {
            URL = url;
        }
    }
}
