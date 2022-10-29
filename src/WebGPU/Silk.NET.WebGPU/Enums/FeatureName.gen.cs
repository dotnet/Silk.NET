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
        [Obsolete("Deprecated in favour of \"Undefined\"")]
        [NativeName("Name", "WGPUFeatureName_Undefined")]
        FeatureNameUndefined = 0x0,
        [Obsolete("Deprecated in favour of \"DepthClipControl\"")]
        [NativeName("Name", "WGPUFeatureName_DepthClipControl")]
        FeatureNameDepthClipControl = 0x1,
        [Obsolete("Deprecated in favour of \"Depth32floatStencil8\"")]
        [NativeName("Name", "WGPUFeatureName_Depth32FloatStencil8")]
        FeatureNameDepth32floatStencil8 = 0x2,
        [Obsolete("Deprecated in favour of \"TimestampQuery\"")]
        [NativeName("Name", "WGPUFeatureName_TimestampQuery")]
        FeatureNameTimestampQuery = 0x3,
        [Obsolete("Deprecated in favour of \"PipelineStatisticsQuery\"")]
        [NativeName("Name", "WGPUFeatureName_PipelineStatisticsQuery")]
        FeatureNamePipelineStatisticsQuery = 0x4,
        [Obsolete("Deprecated in favour of \"TextureCompressionBC\"")]
        [NativeName("Name", "WGPUFeatureName_TextureCompressionBC")]
        FeatureNameTextureCompressionBC = 0x5,
        [Obsolete("Deprecated in favour of \"TextureCompressionEtc2\"")]
        [NativeName("Name", "WGPUFeatureName_TextureCompressionETC2")]
        FeatureNameTextureCompressionEtc2 = 0x6,
        [Obsolete("Deprecated in favour of \"TextureCompressionAstc\"")]
        [NativeName("Name", "WGPUFeatureName_TextureCompressionASTC")]
        FeatureNameTextureCompressionAstc = 0x7,
        [Obsolete("Deprecated in favour of \"IndirectFirstInstance\"")]
        [NativeName("Name", "WGPUFeatureName_IndirectFirstInstance")]
        FeatureNameIndirectFirstInstance = 0x8,
        [Obsolete("Deprecated in favour of \"ShaderF16\"")]
        [NativeName("Name", "WGPUFeatureName_ShaderF16")]
        FeatureNameShaderF16 = 0x9,
        [Obsolete("Deprecated in favour of \"RG11B10UfloatRenderable\"")]
        [NativeName("Name", "WGPUFeatureName_RG11B10UfloatRenderable")]
        FeatureNameRG11B10UfloatRenderable = 0xA,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUFeatureName_Force32")]
        FeatureNameForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUFeatureName_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "WGPUFeatureName_DepthClipControl")]
        DepthClipControl = 0x1,
        [NativeName("Name", "WGPUFeatureName_Depth32FloatStencil8")]
        Depth32floatStencil8 = 0x2,
        [NativeName("Name", "WGPUFeatureName_TimestampQuery")]
        TimestampQuery = 0x3,
        [NativeName("Name", "WGPUFeatureName_PipelineStatisticsQuery")]
        PipelineStatisticsQuery = 0x4,
        [NativeName("Name", "WGPUFeatureName_TextureCompressionBC")]
        TextureCompressionBC = 0x5,
        [NativeName("Name", "WGPUFeatureName_TextureCompressionETC2")]
        TextureCompressionEtc2 = 0x6,
        [NativeName("Name", "WGPUFeatureName_TextureCompressionASTC")]
        TextureCompressionAstc = 0x7,
        [NativeName("Name", "WGPUFeatureName_IndirectFirstInstance")]
        IndirectFirstInstance = 0x8,
        [NativeName("Name", "WGPUFeatureName_ShaderF16")]
        ShaderF16 = 0x9,
        [NativeName("Name", "WGPUFeatureName_RG11B10UfloatRenderable")]
        RG11B10UfloatRenderable = 0xA,
        [NativeName("Name", "WGPUFeatureName_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
