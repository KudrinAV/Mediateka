using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Interfaces;

namespace Mediateka.Classes
{
    class PlayList : MediaItem, IPlayList
    {
        public TimeSpan Duration => throw new NotImplementedException();

        public ICollection<IMediaItem> Items { get; private set; }

        public PlayList(string name, ICollection<IMediaItem> items) : base(name)
        {
            Items = items;
        }


    }
}
