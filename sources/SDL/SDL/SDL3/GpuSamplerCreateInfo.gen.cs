// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

public partial struct GpuSamplerCreateInfo
{
    public GpuFilter MinFilter;
    public GpuFilter MagFilter;
    public GpuSamplerMipmapMode MipmapMode;
    public GpuSamplerAddressMode AddressModeU;
    public GpuSamplerAddressMode AddressModeV;
    public GpuSamplerAddressMode AddressModeW;
    public float MipLodBias;
    public float MaxAnisotropy;
    public GpuCompareOp CompareOp;
    public float MinLod;
    public float MaxLod;

    [NativeTypeName("bool")]
    public byte EnableAnisotropy;

    [NativeTypeName("bool")]
    public byte EnableCompare;

    [NativeTypeName("Uint8")]
    public byte Padding1;

    [NativeTypeName("Uint8")]
    public byte Padding2;

    [NativeTypeName("SDL_PropertiesID")]
    public uint Props;
}
