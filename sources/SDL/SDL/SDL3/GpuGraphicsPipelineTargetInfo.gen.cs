// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

public unsafe partial struct GpuGraphicsPipelineTargetInfo
{
    [NativeTypeName("const SDL_GPUColorTargetDescription *")]
    public GpuColorTargetDescription* ColorTargetDescriptions;

    [NativeTypeName("Uint32")]
    public uint NumColorTargets;
    public GpuTextureFormat DepthStencilFormat;

    [NativeTypeName("bool")]
    public byte HasDepthStencilTarget;

    [NativeTypeName("Uint8")]
    public byte Padding1;

    [NativeTypeName("Uint8")]
    public byte Padding2;

    [NativeTypeName("Uint8")]
    public byte Padding3;
}
