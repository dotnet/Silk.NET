// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS")]
    public enum MULTIPLANEOVERLAYYCbCrFLAGS
    {
        [NativeName("Name", "DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAG_NOMINAL_RANGE")]
        MultiplaneOverlayYCbCrFlagNominalRange = 0x1,
        [NativeName("Name", "DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAG_BT709")]
        MultiplaneOverlayYCbCrFlagBT709 = 0x2,
        [NativeName("Name", "DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAG_xvYCC")]
        MultiplaneOverlayYCbCrFlagXvYcc = 0x4,
    }
}
