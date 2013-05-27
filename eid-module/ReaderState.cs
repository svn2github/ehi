﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Egelke.Fedict.Eid
{
    [Flags]
    internal enum ReaderState : int
    {
        SCARD_STATE_UNAWARE     = 0x0000,
        SCARD_STATE_IGNORE      = 0x0001,
        SCARD_STATE_CHANGED     = 0x0002,
        SCARD_STATE_UNKNOWN     = 0x0004,
        SCARD_STATE_UNAVAILABLE = 0x0008,
        SCARD_STATE_EMPTY       = 0x0010,
        SCARD_STATE_PRESENT     = 0x0020,
        SCARD_STATE_ATRMATCH    = 0x0040,
        SCARD_STATE_EXCLUSIVE   = 0x0080,
        SCARD_STATE_INUSE       = 0x0100,
        SCARD_STATE_MUTE        = 0x0200
    }
}
