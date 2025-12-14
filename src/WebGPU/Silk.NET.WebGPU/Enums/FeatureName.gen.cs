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
        [NativeName("Name", "WGPUFeatureName_TextureCompressionBCSliced3D")]
        TextureCompressionBCSliced3D = 0x5,
        [NativeName("Name", "WGPUFeatureName_TextureCompressionASTCSliced3D")]
        TextureCompressionAstcSliced3D = 0x8,
        [NativeName("Name", "WGPUFeatureName_CoreFeaturesAndLimits")]
        CoreFeaturesAndLimits = 0x1,
        [NativeName("Name", "WGPUFeatureName_DepthClipControl")]
        DepthClipControl = 0x2,
        [NativeName("Name", "WGPUFeatureName_Depth32FloatStencil8")]
        Depth32floatStencil8 = 0x3,
        [NativeName("Name", "WGPUFeatureName_TextureCompressionBC")]
        TextureCompressionBC = 0x4,
        [Obsolete("Deprecated in favour of \"TextureCompressionBCSliced3D\"")]
        [NativeName("Name", "WGPUFeatureName_TextureCompressionBCSliced3D")]
        TextureCompressionBcsliced3D = 0x5,
        [NativeName("Name", "WGPUFeatureName_TextureCompressionETC2")]
        TextureCompressionEtc2 = 0x6,
        [NativeName("Name", "WGPUFeatureName_TextureCompressionASTC")]
        TextureCompressionAstc = 0x7,
        [Obsolete("Deprecated in favour of \"TextureCompressionAstcSliced3D\"")]
        [NativeName("Name", "WGPUFeatureName_TextureCompressionASTCSliced3D")]
        TextureCompressionAstcsliced3D = 0x8,
        [NativeName("Name", "WGPUFeatureName_TimestampQuery")]
        TimestampQuery = 0x9,
        [NativeName("Name", "WGPUFeatureName_IndirectFirstInstance")]
        IndirectFirstInstance = 0xA,
        [NativeName("Name", "WGPUFeatureName_ShaderF16")]
        ShaderF16 = 0xB,
        [NativeName("Name", "WGPUFeatureName_RG11B10UfloatRenderable")]
        RG11B10UfloatRenderable = 0xC,
        [NativeName("Name", "WGPUFeatureName_BGRA8UnormStorage")]
        Bgra8UnormStorage = 0xD,
        [NativeName("Name", "WGPUFeatureName_Float32Filterable")]
        Float32filterable = 0xE,
        [NativeName("Name", "WGPUFeatureName_Float32Blendable")]
        Float32Blendable = 0xF,
        [NativeName("Name", "WGPUFeatureName_ClipDistances")]
        ClipDistances = 0x10,
        [NativeName("Name", "WGPUFeatureName_DualSourceBlending")]
        DualSourceBlending = 0x11,
        [NativeName("Name", "WGPUFeatureName_Subgroups")]
        Subgroups = 0x12,
        [NativeName("Name", "WGPUFeatureName_TextureFormatsTier1")]
        TextureFormatsTier1 = 0x13,
        [NativeName("Name", "WGPUFeatureName_TextureFormatsTier2")]
        TextureFormatsTier2 = 0x14,
        [NativeName("Name", "WGPUFeatureName_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
