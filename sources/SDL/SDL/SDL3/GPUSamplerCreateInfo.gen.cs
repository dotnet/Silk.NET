// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUSamplerCreateInfo")]
public partial struct GPUSamplerCreateInfo
{
    [NativeName("min_filter")]
    public GPUFilter MinFilter;

    [NativeName("mag_filter")]
    public GPUFilter MagFilter;

    [NativeName("mipmap_mode")]
    public GPUSamplerMipmapMode MipmapMode;

    [NativeName("address_mode_u")]
    public GPUSamplerAddressMode AddressModeU;

    [NativeName("address_mode_v")]
    public GPUSamplerAddressMode AddressModeV;

    [NativeName("address_mode_w")]
    public GPUSamplerAddressMode AddressModeW;

    [NativeName("mip_lod_bias")]
    public float MipLodBias;

    [NativeName("max_anisotropy")]
    public float MaxAnisotropy;

    [NativeName("compare_op")]
    public GPUCompareOp CompareOp;

    [NativeName("min_lod")]
    public float MinLod;

    [NativeName("max_lod")]
    public float MaxLod;

    [NativeName("enable_anisotropy")]
    public byte EnableAnisotropy;

    [NativeName("enable_compare")]
    public byte EnableCompare;

    [NativeName("padding1")]
    public byte Padding1;

    [NativeName("padding2")]
    public byte Padding2;

    [NativeName("props")]
    public uint Props;
}
