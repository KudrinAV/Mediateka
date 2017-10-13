using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Classes;
using System.IO;

namespace Mediateka.Interfaces
{
    public interface IMediaItem : INameable
    {
        Rating Rating { get; }
        FileStream MediaStream { get; }
        Int64 PhysicalSize { get; }
        DateTime CreationTime { get; }
        bool AmITrack { get; }
    }
}
