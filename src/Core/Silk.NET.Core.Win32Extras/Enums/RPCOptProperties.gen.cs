// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagRPCOPT_PROPERTIES")]
    public enum RPCOptProperties : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Rpctimeout\"")]
        [NativeName("Name", "COMBND_RPCTIMEOUT")]
        CombndRpctimeout = 0x1,
        [Obsolete("Deprecated in favour of \"ServerLocality\"")]
        [NativeName("Name", "COMBND_SERVER_LOCALITY")]
        CombndServerLocality = 0x2,
        [Obsolete("Deprecated in favour of \"Reserved1\"")]
        [NativeName("Name", "COMBND_RESERVED1")]
        CombndReserved1 = 0x4,
        [Obsolete("Deprecated in favour of \"Reserved2\"")]
        [NativeName("Name", "COMBND_RESERVED2")]
        CombndReserved2 = 0x5,
        [Obsolete("Deprecated in favour of \"Reserved3\"")]
        [NativeName("Name", "COMBND_RESERVED3")]
        CombndReserved3 = 0x8,
        [Obsolete("Deprecated in favour of \"Reserved4\"")]
        [NativeName("Name", "COMBND_RESERVED4")]
        CombndReserved4 = 0x10,
        [NativeName("Name", "COMBND_RPCTIMEOUT")]
        Rpctimeout = 0x1,
        [NativeName("Name", "COMBND_SERVER_LOCALITY")]
        ServerLocality = 0x2,
        [NativeName("Name", "COMBND_RESERVED1")]
        Reserved1 = 0x4,
        [NativeName("Name", "COMBND_RESERVED2")]
        Reserved2 = 0x5,
        [NativeName("Name", "COMBND_RESERVED3")]
        Reserved3 = 0x8,
        [NativeName("Name", "COMBND_RESERVED4")]
        Reserved4 = 0x10,
    }
}
