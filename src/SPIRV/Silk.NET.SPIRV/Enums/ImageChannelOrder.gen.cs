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
        OrderR = 0x0,
        [NativeName("Name", "SpvImageChannelOrderA")]
        OrderA = 0x1,
        [NativeName("Name", "SpvImageChannelOrderRG")]
        OrderRG = 0x2,
        [NativeName("Name", "SpvImageChannelOrderRA")]
        OrderRA = 0x3,
        [NativeName("Name", "SpvImageChannelOrderRGB")]
        OrderRgb = 0x4,
        [NativeName("Name", "SpvImageChannelOrderRGBA")]
        OrderRgba = 0x5,
        [NativeName("Name", "SpvImageChannelOrderBGRA")]
        OrderBgra = 0x6,
        [NativeName("Name", "SpvImageChannelOrderARGB")]
        OrderArgb = 0x7,
        [NativeName("Name", "SpvImageChannelOrderIntensity")]
        OrderIntensity = 0x8,
        [NativeName("Name", "SpvImageChannelOrderLuminance")]
        OrderLuminance = 0x9,
        [NativeName("Name", "SpvImageChannelOrderRx")]
        OrderRx = 0xA,
        [NativeName("Name", "SpvImageChannelOrderRGx")]
        OrderRGx = 0xB,
        [NativeName("Name", "SpvImageChannelOrderRGBx")]
        OrderRGBx = 0xC,
        [NativeName("Name", "SpvImageChannelOrderDepth")]
        OrderDepth = 0xD,
        [NativeName("Name", "SpvImageChannelOrderDepthStencil")]
        OrderDepthStencil = 0xE,
        [NativeName("Name", "SpvImageChannelOrdersRGB")]
        OrdersRgb = 0xF,
        [NativeName("Name", "SpvImageChannelOrdersRGBx")]
        OrdersRGBx = 0x10,
        [NativeName("Name", "SpvImageChannelOrdersRGBA")]
        OrdersRgba = 0x11,
        [NativeName("Name", "SpvImageChannelOrdersBGRA")]
        OrdersBgra = 0x12,
        [NativeName("Name", "SpvImageChannelOrderABGR")]
        OrderAbgr = 0x13,
        [NativeName("Name", "SpvImageChannelOrderMax")]
        OrderMax = 0x7FFFFFFF,
    }
}
