// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public unsafe partial struct GPUColorTargetInfo
{
    public GPUTextureHandle Texture;

    [NativeTypeName("Uint32")]
    public uint MipLevel;

    [NativeTypeName("Uint32")]
    public uint LayerOrDepthPlane;
    public FColor ClearColor;
    public GPULoadOp LoadOp;
    public GPUStoreOp StoreOp;
    public GPUTextureHandle ResolveTexture;

    [NativeTypeName("Uint32")]
    public uint ResolveMipLevel;

    [NativeTypeName("Uint32")]
    public uint ResolveLayer;

    [NativeTypeName("bool")]
    public byte Cycle;

    [NativeTypeName("bool")]
    public byte CycleResolveTexture;

    [NativeTypeName("Uint8")]
    public byte Padding1;

    [NativeTypeName("Uint8")]
    public byte Padding2;
}
