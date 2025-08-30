// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUNativeFeature")]
    public enum NativeFeature : int
    {
        [NativeName("Name", "WGPUNativeFeature_PushConstants")]
        PushConstants = 0x30001,
        [NativeName("Name", "WGPUNativeFeature_TextureAdapterSpecificFormatFeatures")]
        TextureAdapterSpecificFormatFeatures = 0x30002,
        [NativeName("Name", "WGPUNativeFeature_MultiDrawIndirect")]
        MultiDrawIndirect = 0x30003,
        [NativeName("Name", "WGPUNativeFeature_MultiDrawIndirectCount")]
        MultiDrawIndirectCount = 0x30004,
        [NativeName("Name", "WGPUNativeFeature_VertexWritableStorage")]
        VertexWritableStorage = 0x30005,
        [NativeName("Name", "WGPUNativeFeature_TextureBindingArray")]
        TextureBindingArray = 0x30006,
        [NativeName("Name", "WGPUNativeFeature_SampledTextureAndStorageBufferArrayNonUniformIndexing")]
        SampledTextureAndStorageBufferArrayNonUniformIndexing = 0x30007,
        [NativeName("Name", "WGPUNativeFeature_PipelineStatisticsQuery")]
        PipelineStatisticsQuery = 0x30008,
        [NativeName("Name", "WGPUNativeFeature_StorageResourceBindingArray")]
        StorageResourceBindingArray = 0x30009,
        [NativeName("Name", "WGPUNativeFeature_PartiallyBoundBindingArray")]
        PartiallyBoundBindingArray = 0x3000A,
        [NativeName("Name", "WGPUNativeFeature_TextureFormat16bitNorm")]
        TextureFormat16bitNorm = 0x3000B,
        [NativeName("Name", "WGPUNativeFeature_TextureCompressionAstcHdr")]
        TextureCompressionAstcHdr = 0x3000C,
        [NativeName("Name", "WGPUNativeFeature_MappablePrimaryBuffers")]
        MappablePrimaryBuffers = 0x3000E,
        [NativeName("Name", "WGPUNativeFeature_BufferBindingArray")]
        BufferBindingArray = 0x3000F,
        [NativeName("Name", "WGPUNativeFeature_UniformBufferAndStorageTextureArrayNonUniformIndexing")]
        UniformBufferAndStorageTextureArrayNonUniformIndexing = 0x30010,
        [NativeName("Name", "WGPUNativeFeature_VertexAttribute64bit")]
        VertexAttribute64bit = 0x30019,
        [NativeName("Name", "WGPUNativeFeature_ShaderUnusedVertexOutput")]
        ShaderUnusedVertexOutput = 0x3001A,
        [NativeName("Name", "WGPUNativeFeature_TextureFormatNv12")]
        TextureFormatNv12 = 0x3001B,
        [NativeName("Name", "WGPUNativeFeature_RayTracingAccelerationStructure")]
        RayTracingAccelerationStructure = 0x3001C,
        [NativeName("Name", "WGPUNativeFeature_RayQuery")]
        RayQuery = 0x3001D,
        [NativeName("Name", "WGPUNativeFeature_ShaderF64")]
        ShaderF64 = 0x3001E,
        [NativeName("Name", "WGPUNativeFeature_ShaderI16")]
        ShaderI16 = 0x3001F,
        [NativeName("Name", "WGPUNativeFeature_ShaderPrimitiveIndex")]
        ShaderPrimitiveIndex = 0x30020,
        [NativeName("Name", "WGPUNativeFeature_ShaderEarlyDepthTest")]
        ShaderEarlyDepthTest = 0x30021,
        [NativeName("Name", "WGPUNativeFeature_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
