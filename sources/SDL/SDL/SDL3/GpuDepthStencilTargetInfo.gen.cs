// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

public unsafe partial struct GpuDepthStencilTargetInfo
{
    public GpuTextureHandle Texture;
    public float ClearDepth;
    public GpuLoadOp LoadOp;
    public GpuStoreOp StoreOp;
    public GpuLoadOp StencilLoadOp;
    public GpuStoreOp StencilStoreOp;

    [NativeTypeName("bool")]
    public byte Cycle;

    [NativeTypeName("Uint8")]
    public byte ClearStencil;

    [NativeTypeName("Uint8")]
    public byte Padding1;

    [NativeTypeName("Uint8")]
    public byte Padding2;
}
