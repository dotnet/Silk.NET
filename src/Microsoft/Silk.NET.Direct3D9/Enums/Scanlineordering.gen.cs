// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "D3DSCANLINEORDERING")]
    public enum Scanlineordering : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "D3DSCANLINEORDERING_UNKNOWN")]
        ScanlineorderingUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"Progressive\"")]
        [NativeName("Name", "D3DSCANLINEORDERING_PROGRESSIVE")]
        ScanlineorderingProgressive = 0x1,
        [Obsolete("Deprecated in favour of \"Interlaced\"")]
        [NativeName("Name", "D3DSCANLINEORDERING_INTERLACED")]
        ScanlineorderingInterlaced = 0x2,
        [NativeName("Name", "D3DSCANLINEORDERING_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "D3DSCANLINEORDERING_PROGRESSIVE")]
        Progressive = 0x1,
        [NativeName("Name", "D3DSCANLINEORDERING_INTERLACED")]
        Interlaced = 0x2,
    }
}
