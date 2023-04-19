// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvImageChannelOrder_")]
    public enum ImageChannelOrder : int
    {
        [NativeName("Name", "SpvImageChannelOrderR")]
        R = 0x0,
        [NativeName("Name", "SpvImageChannelOrderA")]
        A = 0x1,
        [NativeName("Name", "SpvImageChannelOrderRG")]
        RG = 0x2,
        [NativeName("Name", "SpvImageChannelOrderRA")]
        RA = 0x3,
        [NativeName("Name", "SpvImageChannelOrderRGB")]
        Rgb = 0x4,
        [NativeName("Name", "SpvImageChannelOrderRGBA")]
        Rgba = 0x5,
        [NativeName("Name", "SpvImageChannelOrderBGRA")]
        Bgra = 0x6,
        [NativeName("Name", "SpvImageChannelOrderARGB")]
        Argb = 0x7,
        [NativeName("Name", "SpvImageChannelOrderIntensity")]
        Intensity = 0x8,
        [NativeName("Name", "SpvImageChannelOrderLuminance")]
        Luminance = 0x9,
        [NativeName("Name", "SpvImageChannelOrderRx")]
        Rx = 0xA,
        [NativeName("Name", "SpvImageChannelOrderRGx")]
        RGx = 0xB,
        [NativeName("Name", "SpvImageChannelOrderRGBx")]
        RGBx = 0xC,
        [NativeName("Name", "SpvImageChannelOrderDepth")]
        Depth = 0xD,
        [NativeName("Name", "SpvImageChannelOrderDepthStencil")]
        DepthStencil = 0xE,
        [NativeName("Name", "SpvImageChannelOrdersRGB")]
        Rgb = 0xF,
        [NativeName("Name", "SpvImageChannelOrdersRGBx")]
        RGBx = 0x10,
        [NativeName("Name", "SpvImageChannelOrdersRGBA")]
        Rgba = 0x11,
        [NativeName("Name", "SpvImageChannelOrdersBGRA")]
        Bgra = 0x12,
        [NativeName("Name", "SpvImageChannelOrderABGR")]
        Abgr = 0x13,
        [NativeName("Name", "SpvImageChannelOrderMax")]
        Max = 0x7FFFFFFF,
    }
}
