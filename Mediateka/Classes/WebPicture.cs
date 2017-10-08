using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Interfaces;

namespace Mediateka.Classes
{
    class WebPicture : Picture, IWebElement
    {
        public string URL => throw new NotImplementedException();
    }
}
