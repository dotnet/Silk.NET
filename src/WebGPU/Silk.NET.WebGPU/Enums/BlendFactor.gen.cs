// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUBlendFactor")]
    public enum BlendFactor : int
    {
        [NativeName("Name", "WGPUBlendFactor_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "WGPUBlendFactor_Zero")]
        Zero = 0x1,
        [NativeName("Name", "WGPUBlendFactor_One")]
        One = 0x2,
        [NativeName("Name", "WGPUBlendFactor_Src")]
        Src = 0x3,
        [NativeName("Name", "WGPUBlendFactor_OneMinusSrc")]
        OneMinusSrc = 0x4,
        [NativeName("Name", "WGPUBlendFactor_SrcAlpha")]
        SrcAlpha = 0x5,
        [NativeName("Name", "WGPUBlendFactor_OneMinusSrcAlpha")]
        OneMinusSrcAlpha = 0x6,
        [NativeName("Name", "WGPUBlendFactor_Dst")]
        Dst = 0x7,
        [NativeName("Name", "WGPUBlendFactor_OneMinusDst")]
        OneMinusDst = 0x8,
        [NativeName("Name", "WGPUBlendFactor_DstAlpha")]
        DstAlpha = 0x9,
        [NativeName("Name", "WGPUBlendFactor_OneMinusDstAlpha")]
        OneMinusDstAlpha = 0xA,
        [NativeName("Name", "WGPUBlendFactor_SrcAlphaSaturated")]
        SrcAlphaSaturated = 0xB,
        [NativeName("Name", "WGPUBlendFactor_Constant")]
        Constant = 0xC,
        [NativeName("Name", "WGPUBlendFactor_OneMinusConstant")]
        OneMinusConstant = 0xD,
        [NativeName("Name", "WGPUBlendFactor_Src1")]
        Src1 = 0xE,
        [NativeName("Name", "WGPUBlendFactor_OneMinusSrc1")]
        OneMinusSrc1 = 0xF,
        [NativeName("Name", "WGPUBlendFactor_Src1Alpha")]
        Src1Alpha = 0x10,
        [NativeName("Name", "WGPUBlendFactor_OneMinusSrc1Alpha")]
        OneMinusSrc1Alpha = 0x11,
        [NativeName("Name", "WGPUBlendFactor_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
