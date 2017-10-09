﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Interfaces
{
    interface ITrack : IMediaItem
    {
        TimeSpan Duration { get; }
        String Genre { get; }
    }
}
