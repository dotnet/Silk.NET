// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [Flags]
    [NativeName("Name", "DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS")]
    public enum MULTIPLANEOVERLAYYCbCrFLAGS : int
    {
        [NativeName("Name", "DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAG_NOMINAL_RANGE")]
        MultiplaneOverlayYCbCrFlagNominalRange = 0x1,
        [NativeName("Name", "DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAG_BT709")]
        MultiplaneOverlayYCbCrFlagBT709 = 0x2,
        [NativeName("Name", "DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAG_xvYCC")]
        MultiplaneOverlayYCbCrFlagXvYcc = 0x4,
    }
}
