// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSamplerCreateInfo")]
public unsafe partial struct SamplerCreateInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.SamplerCreateInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public SamplerCreateFlags Flags;

    [NativeName("magFilter")]
    public Filter MagFilter;

    [NativeName("minFilter")]
    public Filter MinFilter;

    [NativeName("mipmapMode")]
    public SamplerMipmapMode MipmapMode;

    [NativeName("addressModeU")]
    public SamplerAddressMode AddressModeU;

    [NativeName("addressModeV")]
    public SamplerAddressMode AddressModeV;

    [NativeName("addressModeW")]
    public SamplerAddressMode AddressModeW;

    [NativeName("mipLodBias")]
    public float MipLodBias;

    [NativeName("anisotropyEnable")]
    public MaybeBool<uint> AnisotropyEnable;

    [NativeName("maxAnisotropy")]
    public float MaxAnisotropy;

    [NativeName("compareEnable")]
    public MaybeBool<uint> CompareEnable;

    [NativeName("compareOp")]
    public CompareOp CompareOp;

    [NativeName("minLod")]
    public float MinLod;

    [NativeName("maxLod")]
    public float MaxLod;

    [NativeName("borderColor")]
    public BorderColor BorderColor;

    [NativeName("unnormalizedCoordinates")]
    public MaybeBool<uint> UnnormalizedCoordinates;

    public SamplerCreateInfo() { }
}
