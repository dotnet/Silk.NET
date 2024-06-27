// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagSTATFLAG")]
    public enum StatFlag : int
    {
        [Obsolete("Deprecated in favour of \"Default\"")]
        [NativeName("Name", "STATFLAG_DEFAULT")]
        StatflagDefault = 0x0,
        [Obsolete("Deprecated in favour of \"Noname\"")]
        [NativeName("Name", "STATFLAG_NONAME")]
        StatflagNoname = 0x1,
        [Obsolete("Deprecated in favour of \"Noopen\"")]
        [NativeName("Name", "STATFLAG_NOOPEN")]
        StatflagNoopen = 0x2,
        [NativeName("Name", "STATFLAG_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "STATFLAG_NONAME")]
        Noname = 0x1,
        [NativeName("Name", "STATFLAG_NOOPEN")]
        Noopen = 0x2,
    }
}
