using Mediateka.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Mediateka.Interfaces;

namespace Mediateka
{
    public class Mediateka : ICollection<IMediaItem>
    {
        private ICollection<IMediaItem> mediaItems = new List<IMediaItem>();

        public int Count { get { return mediaItems.Count; } }

        public bool IsReadOnly { get { return mediaItems.IsReadOnly; } }

        public void Add(IMediaItem item)
        {
            mediaItems.Add(item);
        }

        public void Clear()
        {
            mediaItems.Clear();
        }

        public bool Contains(IMediaItem item)
        {
            return mediaItems.Contains(item);
        }

        public void CopyTo(IMediaItem[] array, int arrayIndex)
        {
            mediaItems.CopyTo(array, arrayIndex);
        }

        public IEnumerator<IMediaItem> GetEnumerator()
        {
            return mediaItems.GetEnumerator();
        }

        public bool Remove(IMediaItem item)
        {
            return mediaItems.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return mediaItems.GetEnumerator();
        }

    }
}
