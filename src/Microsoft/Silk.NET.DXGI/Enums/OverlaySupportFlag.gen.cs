// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_OVERLAY_SUPPORT_FLAG")]
    public enum OverlaySupportFlag : int
    {
        [NativeName("Name", "DXGI_OVERLAY_SUPPORT_FLAG_DIRECT")]
        OverlaySupportFlagDirect = 0x1,
        [NativeName("Name", "DXGI_OVERLAY_SUPPORT_FLAG_SCALING")]
        OverlaySupportFlagScaling = 0x2,
    }
}
