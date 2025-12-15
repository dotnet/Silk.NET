// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUFeatureName")]
    public enum FeatureName : int
    {
        [NativeName("Name", "WGPUFeatureName_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "WGPUFeatureName_DepthClipControl")]
        DepthClipControl = 0x1,
        [NativeName("Name", "WGPUFeatureName_Depth32FloatStencil8")]
        Depth32floatStencil8 = 0x2,
        [NativeName("Name", "WGPUFeatureName_TimestampQuery")]
        TimestampQuery = 0x3,
        [NativeName("Name", "WGPUFeatureName_TextureCompressionBC")]
        TextureCompressionBC = 0x4,
        [NativeName("Name", "WGPUFeatureName_TextureCompressionETC2")]
        TextureCompressionEtc2 = 0x5,
        [NativeName("Name", "WGPUFeatureName_TextureCompressionASTC")]
        TextureCompressionAstc = 0x6,
        [NativeName("Name", "WGPUFeatureName_IndirectFirstInstance")]
        IndirectFirstInstance = 0x7,
        [NativeName("Name", "WGPUFeatureName_ShaderF16")]
        ShaderF16 = 0x8,
        [NativeName("Name", "WGPUFeatureName_RG11B10UfloatRenderable")]
        RG11B10UfloatRenderable = 0x9,
        [NativeName("Name", "WGPUFeatureName_BGRA8UnormStorage")]
        Bgra8UnormStorage = 0xA,
        [NativeName("Name", "WGPUFeatureName_Float32Filterable")]
        Float32filterable = 0xB,
        [NativeName("Name", "WGPUFeatureName_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
