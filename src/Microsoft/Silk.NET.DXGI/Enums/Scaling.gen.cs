// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_SCALING")]
    public enum Scaling : int
    {
        [NativeName("Name", "DXGI_SCALING_STRETCH")]
        ScalingStretch = 0x0,
        [NativeName("Name", "DXGI_SCALING_NONE")]
        ScalingNone = 0x1,
        [NativeName("Name", "DXGI_SCALING_ASPECT_RATIO_STRETCH")]
        ScalingAspectRatioStretch = 0x2,
    }
}
