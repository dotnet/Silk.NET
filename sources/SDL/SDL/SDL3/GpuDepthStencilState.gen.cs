// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUDepthStencilState")]
public partial struct GpuDepthStencilState
{
    [NativeName("compare_op")]
    public GpuCompareOp CompareOp;

    [NativeName("back_stencil_state")]
    public GpuStencilOpState BackStencilState;

    [NativeName("front_stencil_state")]
    public GpuStencilOpState FrontStencilState;

    [NativeName("compare_mask")]
    public byte CompareMask;

    [NativeName("write_mask")]
    public byte WriteMask;

    [NativeName("enable_depth_test")]
    public byte EnableDepthTest;

    [NativeName("enable_depth_write")]
    public byte EnableDepthWrite;

    [NativeName("enable_stencil_test")]
    public byte EnableStencilTest;

    [NativeName("padding1")]
    public byte Padding1;

    [NativeName("padding2")]
    public byte Padding2;

    [NativeName("padding3")]
    public byte Padding3;
}
