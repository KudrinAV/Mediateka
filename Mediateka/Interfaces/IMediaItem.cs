﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Classes;
using System.IO;

namespace Mediateka.Interfaces
{
    public interface IMediaItem 
    {
        Rating Rating { get; }
        StreamReader MediaStream { get; }
        Int64 PhysicalSize { get; }
        DateTime CreationTime { get; }
    }
}
