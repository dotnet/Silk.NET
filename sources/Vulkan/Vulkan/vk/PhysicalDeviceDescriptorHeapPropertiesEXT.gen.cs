// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceDescriptorHeapPropertiesEXT")]
public unsafe partial struct PhysicalDeviceDescriptorHeapPropertiesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceDescriptorHeapPropertiesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("samplerHeapAlignment")]
    public ulong SamplerHeapAlignment;

    [NativeName("resourceHeapAlignment")]
    public ulong ResourceHeapAlignment;

    [NativeName("maxSamplerHeapSize")]
    public ulong MaxSamplerHeapSize;

    [NativeName("maxResourceHeapSize")]
    public ulong MaxResourceHeapSize;

    [NativeName("minSamplerHeapReservedRange")]
    public ulong MinSamplerHeapReservedRange;

    [NativeName("minSamplerHeapReservedRangeWithEmbedded")]
    public ulong MinSamplerHeapReservedRangeWithEmbedded;

    [NativeName("minResourceHeapReservedRange")]
    public ulong MinResourceHeapReservedRange;

    [NativeName("samplerDescriptorSize")]
    public ulong SamplerDescriptorSize;

    [NativeName("imageDescriptorSize")]
    public ulong ImageDescriptorSize;

    [NativeName("bufferDescriptorSize")]
    public ulong BufferDescriptorSize;

    [NativeName("samplerDescriptorAlignment")]
    public ulong SamplerDescriptorAlignment;

    [NativeName("imageDescriptorAlignment")]
    public ulong ImageDescriptorAlignment;

    [NativeName("bufferDescriptorAlignment")]
    public ulong BufferDescriptorAlignment;

    [NativeName("maxPushDataSize")]
    public ulong MaxPushDataSize;

    [NativeName("imageCaptureReplayOpaqueDataSize")]
    public nuint ImageCaptureReplayOpaqueDataSize;

    [NativeName("maxDescriptorHeapEmbeddedSamplers")]
    public uint MaxDescriptorHeapEmbeddedSamplers;

    [NativeName("samplerYcbcrConversionCount")]
    public uint SamplerYcbcrConversionCount;

    [NativeName("sparseDescriptorHeaps")]
    public MaybeBool<uint> SparseDescriptorHeaps;

    [NativeName("protectedDescriptorHeaps")]
    public MaybeBool<uint> ProtectedDescriptorHeaps;

    public PhysicalDeviceDescriptorHeapPropertiesEXT() { }
}
