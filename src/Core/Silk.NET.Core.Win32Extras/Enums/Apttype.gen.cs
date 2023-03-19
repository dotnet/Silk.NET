// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "_APTTYPE")]
    public enum Apttype : int
    {
        [Obsolete("Deprecated in favour of \"Current\"")]
        [NativeName("Name", "APTTYPE_CURRENT")]
        ApttypeCurrent = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [Obsolete("Deprecated in favour of \"Sta\"")]
        [NativeName("Name", "APTTYPE_STA")]
        ApttypeSta = 0x0,
        [Obsolete("Deprecated in favour of \"Mta\"")]
        [NativeName("Name", "APTTYPE_MTA")]
        ApttypeMta = 0x1,
        [Obsolete("Deprecated in favour of \"NA\"")]
        [NativeName("Name", "APTTYPE_NA")]
        ApttypeNA = 0x2,
        [Obsolete("Deprecated in favour of \"Mainsta\"")]
        [NativeName("Name", "APTTYPE_MAINSTA")]
        ApttypeMainsta = 0x3,
        [NativeName("Name", "APTTYPE_CURRENT")]
        Current = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "APTTYPE_STA")]
        Sta = 0x0,
        [NativeName("Name", "APTTYPE_MTA")]
        Mta = 0x1,
        [NativeName("Name", "APTTYPE_NA")]
        NA = 0x2,
        [NativeName("Name", "APTTYPE_MAINSTA")]
        Mainsta = 0x3,
    }
}
