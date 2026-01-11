// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUColorTargetInfo")]
public unsafe partial struct GpuColorTargetInfo
{
    [NativeName("texture")]
    public GpuTextureHandle Texture;

    [NativeName("mip_level")]
    public uint MipLevel;

    [NativeName("layer_or_depth_plane")]
    public uint LayerOrDepthPlane;

    [NativeName("clear_color")]
    public FColor ClearColor;

    [NativeName("load_op")]
    public GpuLoadOp LoadOp;

    [NativeName("store_op")]
    public GpuStoreOp StoreOp;

    [NativeName("resolve_texture")]
    public GpuTextureHandle ResolveTexture;

    [NativeName("resolve_mip_level")]
    public uint ResolveMipLevel;

    [NativeName("resolve_layer")]
    public uint ResolveLayer;

    [NativeName("cycle")]
    public byte Cycle;

    [NativeName("cycle_resolve_texture")]
    public byte CycleResolveTexture;

    [NativeName("padding1")]
    public byte Padding1;

    [NativeName("padding2")]
    public byte Padding2;
}
