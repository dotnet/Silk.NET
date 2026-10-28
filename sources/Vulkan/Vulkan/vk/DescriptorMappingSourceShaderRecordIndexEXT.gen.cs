// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDescriptorMappingSourceShaderRecordIndexEXT")]
public unsafe partial struct DescriptorMappingSourceShaderRecordIndexEXT
{
    [NativeName("heapOffset")]
    public uint HeapOffset;

    [NativeName("shaderRecordOffset")]
    public uint ShaderRecordOffset;

    [NativeName("heapIndexStride")]
    public uint HeapIndexStride;

    [NativeName("heapArrayStride")]
    public uint HeapArrayStride;

    [NativeName("pEmbeddedSampler")]
    public SamplerCreateInfo* PEmbeddedSampler;

    [NativeName("useCombinedImageSamplerIndex")]
    public MaybeBool<uint> UseCombinedImageSamplerIndex;

    [NativeName("samplerHeapOffset")]
    public uint SamplerHeapOffset;

    [NativeName("samplerShaderRecordOffset")]
    public uint SamplerShaderRecordOffset;

    [NativeName("samplerHeapIndexStride")]
    public uint SamplerHeapIndexStride;

    [NativeName("samplerHeapArrayStride")]
    public uint SamplerHeapArrayStride;
}
