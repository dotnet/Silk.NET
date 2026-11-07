// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceDescriptorBufferPropertiesEXT")]
public unsafe partial struct PhysicalDeviceDescriptorBufferPropertiesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceDescriptorBufferPropertiesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("combinedImageSamplerDescriptorSingleArray")]
    public MaybeBool<uint> CombinedImageSamplerDescriptorSingleArray;

    [NativeName("bufferlessPushDescriptors")]
    public MaybeBool<uint> BufferlessPushDescriptors;

    [NativeName("allowSamplerImageViewPostSubmitCreation")]
    public MaybeBool<uint> AllowSamplerImageViewPostSubmitCreation;

    [NativeName("descriptorBufferOffsetAlignment")]
    public ulong DescriptorBufferOffsetAlignment;

    [NativeName("maxDescriptorBufferBindings")]
    public uint MaxDescriptorBufferBindings;

    [NativeName("maxResourceDescriptorBufferBindings")]
    public uint MaxResourceDescriptorBufferBindings;

    [NativeName("maxSamplerDescriptorBufferBindings")]
    public uint MaxSamplerDescriptorBufferBindings;

    [NativeName("maxEmbeddedImmutableSamplerBindings")]
    public uint MaxEmbeddedImmutableSamplerBindings;

    [NativeName("maxEmbeddedImmutableSamplers")]
    public uint MaxEmbeddedImmutableSamplers;

    [NativeName("bufferCaptureReplayDescriptorDataSize")]
    public nuint BufferCaptureReplayDescriptorDataSize;

    [NativeName("imageCaptureReplayDescriptorDataSize")]
    public nuint ImageCaptureReplayDescriptorDataSize;

    [NativeName("imageViewCaptureReplayDescriptorDataSize")]
    public nuint ImageViewCaptureReplayDescriptorDataSize;

    [NativeName("samplerCaptureReplayDescriptorDataSize")]
    public nuint SamplerCaptureReplayDescriptorDataSize;

    [NativeName("accelerationStructureCaptureReplayDescriptorDataSize")]
    public nuint AccelerationStructureCaptureReplayDescriptorDataSize;

    [NativeName("samplerDescriptorSize")]
    public nuint SamplerDescriptorSize;

    [NativeName("combinedImageSamplerDescriptorSize")]
    public nuint CombinedImageSamplerDescriptorSize;

    [NativeName("sampledImageDescriptorSize")]
    public nuint SampledImageDescriptorSize;

    [NativeName("storageImageDescriptorSize")]
    public nuint StorageImageDescriptorSize;

    [NativeName("uniformTexelBufferDescriptorSize")]
    public nuint UniformTexelBufferDescriptorSize;

    [NativeName("robustUniformTexelBufferDescriptorSize")]
    public nuint RobustUniformTexelBufferDescriptorSize;

    [NativeName("storageTexelBufferDescriptorSize")]
    public nuint StorageTexelBufferDescriptorSize;

    [NativeName("robustStorageTexelBufferDescriptorSize")]
    public nuint RobustStorageTexelBufferDescriptorSize;

    [NativeName("uniformBufferDescriptorSize")]
    public nuint UniformBufferDescriptorSize;

    [NativeName("robustUniformBufferDescriptorSize")]
    public nuint RobustUniformBufferDescriptorSize;

    [NativeName("storageBufferDescriptorSize")]
    public nuint StorageBufferDescriptorSize;

    [NativeName("robustStorageBufferDescriptorSize")]
    public nuint RobustStorageBufferDescriptorSize;

    [NativeName("inputAttachmentDescriptorSize")]
    public nuint InputAttachmentDescriptorSize;

    [NativeName("accelerationStructureDescriptorSize")]
    public nuint AccelerationStructureDescriptorSize;

    [NativeName("maxSamplerDescriptorBufferRange")]
    public ulong MaxSamplerDescriptorBufferRange;

    [NativeName("maxResourceDescriptorBufferRange")]
    public ulong MaxResourceDescriptorBufferRange;

    [NativeName("samplerDescriptorBufferAddressSpaceSize")]
    public ulong SamplerDescriptorBufferAddressSpaceSize;

    [NativeName("resourceDescriptorBufferAddressSpaceSize")]
    public ulong ResourceDescriptorBufferAddressSpaceSize;

    [NativeName("descriptorBufferAddressSpaceSize")]
    public ulong DescriptorBufferAddressSpaceSize;

    public PhysicalDeviceDescriptorBufferPropertiesEXT() { }
}
