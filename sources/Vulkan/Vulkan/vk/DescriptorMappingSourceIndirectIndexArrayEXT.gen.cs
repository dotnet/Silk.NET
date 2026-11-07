// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDescriptorMappingSourceIndirectIndexArrayEXT")]
public unsafe partial struct DescriptorMappingSourceIndirectIndexArrayEXT
{
    [NativeName("heapOffset")]
    public uint HeapOffset;

    [NativeName("pushOffset")]
    public uint PushOffset;

    [NativeName("addressOffset")]
    public uint AddressOffset;

    [NativeName("heapIndexStride")]
    public uint HeapIndexStride;

    [NativeName("pEmbeddedSampler")]
    public SamplerCreateInfo* PEmbeddedSampler;

    [NativeName("useCombinedImageSamplerIndex")]
    public MaybeBool<uint> UseCombinedImageSamplerIndex;

    [NativeName("samplerHeapOffset")]
    public uint SamplerHeapOffset;

    [NativeName("samplerPushOffset")]
    public uint SamplerPushOffset;

    [NativeName("samplerAddressOffset")]
    public uint SamplerAddressOffset;

    [NativeName("samplerHeapIndexStride")]
    public uint SamplerHeapIndexStride;
}
