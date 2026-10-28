// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDescriptorDataEXT")]
[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct DescriptorDataEXT
{
    [NativeName("pSampler")]
    [FieldOffset(0)]
    public SamplerHandle* PSampler;

    [NativeName("pCombinedImageSampler")]
    [FieldOffset(0)]
    public DescriptorImageInfo* PCombinedImageSampler;

    [NativeName("pInputAttachmentImage")]
    [FieldOffset(0)]
    public DescriptorImageInfo* PInputAttachmentImage;

    [NativeName("pSampledImage")]
    [FieldOffset(0)]
    public DescriptorImageInfo* PSampledImage;

    [NativeName("pStorageImage")]
    [FieldOffset(0)]
    public DescriptorImageInfo* PStorageImage;

    [NativeName("pUniformTexelBuffer")]
    [FieldOffset(0)]
    public DescriptorAddressInfoEXT* PUniformTexelBuffer;

    [NativeName("pStorageTexelBuffer")]
    [FieldOffset(0)]
    public DescriptorAddressInfoEXT* PStorageTexelBuffer;

    [NativeName("pUniformBuffer")]
    [FieldOffset(0)]
    public DescriptorAddressInfoEXT* PUniformBuffer;

    [NativeName("pStorageBuffer")]
    [FieldOffset(0)]
    public DescriptorAddressInfoEXT* PStorageBuffer;

    [NativeName("accelerationStructure")]
    [FieldOffset(0)]
    public ulong AccelerationStructure;
}
