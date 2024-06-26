// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagHITRESULT")]
    public enum HitResult : int
    {
        [Obsolete("Deprecated in favour of \"Outside\"")]
        [NativeName("Name", "HITRESULT_OUTSIDE")]
        HitresultOutside = 0x0,
        [Obsolete("Deprecated in favour of \"Transparent\"")]
        [NativeName("Name", "HITRESULT_TRANSPARENT")]
        HitresultTransparent = 0x1,
        [Obsolete("Deprecated in favour of \"Close\"")]
        [NativeName("Name", "HITRESULT_CLOSE")]
        HitresultClose = 0x2,
        [Obsolete("Deprecated in favour of \"Hit\"")]
        [NativeName("Name", "HITRESULT_HIT")]
        HitresultHit = 0x3,
        [NativeName("Name", "HITRESULT_OUTSIDE")]
        Outside = 0x0,
        [NativeName("Name", "HITRESULT_TRANSPARENT")]
        Transparent = 0x1,
        [NativeName("Name", "HITRESULT_CLOSE")]
        Close = 0x2,
        [NativeName("Name", "HITRESULT_HIT")]
        Hit = 0x3,
    }
}
