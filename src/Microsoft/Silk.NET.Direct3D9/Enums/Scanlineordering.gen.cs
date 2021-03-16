// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
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
