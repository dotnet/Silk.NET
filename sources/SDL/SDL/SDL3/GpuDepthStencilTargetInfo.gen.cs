// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUDepthStencilTargetInfo")]
public unsafe partial struct GpuDepthStencilTargetInfo
{
    [NativeName("texture")]
    public GpuTextureHandle Texture;

    [NativeName("clear_depth")]
    public float ClearDepth;

    [NativeName("load_op")]
    public GpuLoadOp LoadOp;

    [NativeName("store_op")]
    public GpuStoreOp StoreOp;

    [NativeName("stencil_load_op")]
    public GpuLoadOp StencilLoadOp;

    [NativeName("stencil_store_op")]
    public GpuStoreOp StencilStoreOp;

    [NativeName("cycle")]
    public byte Cycle;

    [NativeName("clear_stencil")]
    public byte ClearStencil;

    [NativeName("padding1")]
    public byte Padding1;

    [NativeName("padding2")]
    public byte Padding2;
}
