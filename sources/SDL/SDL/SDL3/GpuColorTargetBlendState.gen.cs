// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUColorTargetBlendState")]
public partial struct GpuColorTargetBlendState
{
    [NativeName("src_color_blendfactor")]
    public GpuBlendFactor SrcColorBlendfactor;

    [NativeName("dst_color_blendfactor")]
    public GpuBlendFactor DstColorBlendfactor;

    [NativeName("color_blend_op")]
    public GpuBlendOp ColorBlendOp;

    [NativeName("src_alpha_blendfactor")]
    public GpuBlendFactor SrcAlphaBlendfactor;

    [NativeName("dst_alpha_blendfactor")]
    public GpuBlendFactor DstAlphaBlendfactor;

    [NativeName("alpha_blend_op")]
    public GpuBlendOp AlphaBlendOp;

    [NativeName("color_write_mask")]
    public byte ColorWriteMask;

    [NativeName("enable_blend")]
    public byte EnableBlend;

    [NativeName("enable_color_write_mask")]
    public byte EnableColorWriteMask;

    [NativeName("padding1")]
    public byte Padding1;

    [NativeName("padding2")]
    public byte Padding2;
}
