// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
    [NativeName("Name", "D3DSCANLINEORDERING")]
    public enum Scanlineordering : int
    {
        [NativeName("Name", "D3DSCANLINEORDERING_UNKNOWN")]
        ScanlineorderingUnknown = 0x0,
        [NativeName("Name", "D3DSCANLINEORDERING_PROGRESSIVE")]
        ScanlineorderingProgressive = 0x1,
        [NativeName("Name", "D3DSCANLINEORDERING_INTERLACED")]
        ScanlineorderingInterlaced = 0x2,
    }
}
