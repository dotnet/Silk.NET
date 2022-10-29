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
        [Obsolete("Deprecated in favour of \"Zero\"")]
        [NativeName("Name", "WGPUBlendFactor_Zero")]
        BlendFactorZero = 0x0,
        [Obsolete("Deprecated in favour of \"One\"")]
        [NativeName("Name", "WGPUBlendFactor_One")]
        BlendFactorOne = 0x1,
        [Obsolete("Deprecated in favour of \"Src\"")]
        [NativeName("Name", "WGPUBlendFactor_Src")]
        BlendFactorSrc = 0x2,
        [Obsolete("Deprecated in favour of \"OneMinusSrc\"")]
        [NativeName("Name", "WGPUBlendFactor_OneMinusSrc")]
        BlendFactorOneMinusSrc = 0x3,
        [Obsolete("Deprecated in favour of \"SrcAlpha\"")]
        [NativeName("Name", "WGPUBlendFactor_SrcAlpha")]
        BlendFactorSrcAlpha = 0x4,
        [Obsolete("Deprecated in favour of \"OneMinusSrcAlpha\"")]
        [NativeName("Name", "WGPUBlendFactor_OneMinusSrcAlpha")]
        BlendFactorOneMinusSrcAlpha = 0x5,
        [Obsolete("Deprecated in favour of \"Dst\"")]
        [NativeName("Name", "WGPUBlendFactor_Dst")]
        BlendFactorDst = 0x6,
        [Obsolete("Deprecated in favour of \"OneMinusDst\"")]
        [NativeName("Name", "WGPUBlendFactor_OneMinusDst")]
        BlendFactorOneMinusDst = 0x7,
        [Obsolete("Deprecated in favour of \"DstAlpha\"")]
        [NativeName("Name", "WGPUBlendFactor_DstAlpha")]
        BlendFactorDstAlpha = 0x8,
        [Obsolete("Deprecated in favour of \"OneMinusDstAlpha\"")]
        [NativeName("Name", "WGPUBlendFactor_OneMinusDstAlpha")]
        BlendFactorOneMinusDstAlpha = 0x9,
        [Obsolete("Deprecated in favour of \"SrcAlphaSaturated\"")]
        [NativeName("Name", "WGPUBlendFactor_SrcAlphaSaturated")]
        BlendFactorSrcAlphaSaturated = 0xA,
        [Obsolete("Deprecated in favour of \"Constant\"")]
        [NativeName("Name", "WGPUBlendFactor_Constant")]
        BlendFactorConstant = 0xB,
        [Obsolete("Deprecated in favour of \"OneMinusConstant\"")]
        [NativeName("Name", "WGPUBlendFactor_OneMinusConstant")]
        BlendFactorOneMinusConstant = 0xC,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUBlendFactor_Force32")]
        BlendFactorForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUBlendFactor_Zero")]
        Zero = 0x0,
        [NativeName("Name", "WGPUBlendFactor_One")]
        One = 0x1,
        [NativeName("Name", "WGPUBlendFactor_Src")]
        Src = 0x2,
        [NativeName("Name", "WGPUBlendFactor_OneMinusSrc")]
        OneMinusSrc = 0x3,
        [NativeName("Name", "WGPUBlendFactor_SrcAlpha")]
        SrcAlpha = 0x4,
        [NativeName("Name", "WGPUBlendFactor_OneMinusSrcAlpha")]
        OneMinusSrcAlpha = 0x5,
        [NativeName("Name", "WGPUBlendFactor_Dst")]
        Dst = 0x6,
        [NativeName("Name", "WGPUBlendFactor_OneMinusDst")]
        OneMinusDst = 0x7,
        [NativeName("Name", "WGPUBlendFactor_DstAlpha")]
        DstAlpha = 0x8,
        [NativeName("Name", "WGPUBlendFactor_OneMinusDstAlpha")]
        OneMinusDstAlpha = 0x9,
        [NativeName("Name", "WGPUBlendFactor_SrcAlphaSaturated")]
        SrcAlphaSaturated = 0xA,
        [NativeName("Name", "WGPUBlendFactor_Constant")]
        Constant = 0xB,
        [NativeName("Name", "WGPUBlendFactor_OneMinusConstant")]
        OneMinusConstant = 0xC,
        [NativeName("Name", "WGPUBlendFactor_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
