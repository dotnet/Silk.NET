// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUGraphicsPipelineTargetInfo")]
public unsafe partial struct GpuGraphicsPipelineTargetInfo
{
    [NativeName("color_target_descriptions")]
    public GpuColorTargetDescription* ColorTargetDescriptions;

    [NativeName("num_color_targets")]
    public uint NumColorTargets;

    [NativeName("depth_stencil_format")]
    public GpuTextureFormat DepthStencilFormat;

    [NativeName("has_depth_stencil_target")]
    public byte HasDepthStencilTarget;

    [NativeName("padding1")]
    public byte Padding1;

    [NativeName("padding2")]
    public byte Padding2;

    [NativeName("padding3")]
    public byte Padding3;
}
