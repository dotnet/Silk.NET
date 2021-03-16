// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_MODE_SCALING")]
    public enum ModeScaling : int
    {
        [NativeName("Name", "DXGI_MODE_SCALING_UNSPECIFIED")]
        ModeScalingUnspecified = 0x0,
        [NativeName("Name", "DXGI_MODE_SCALING_CENTERED")]
        ModeScalingCentered = 0x1,
        [NativeName("Name", "DXGI_MODE_SCALING_STRETCHED")]
        ModeScalingStretched = 0x2,
    }
}
