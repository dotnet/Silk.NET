// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public partial struct GPUColorTargetBlendState
{
    public GPUBlendFactor SrcColorBlendfactor;
    public GPUBlendFactor DstColorBlendfactor;
    public GPUBlendOp ColorBlendOp;
    public GPUBlendFactor SrcAlphaBlendfactor;
    public GPUBlendFactor DstAlphaBlendfactor;
    public GPUBlendOp AlphaBlendOp;

    [NativeTypeName("SDL_GPUColorComponentFlags")]
    public byte ColorWriteMask;

    [NativeTypeName("bool")]
    public byte EnableBlend;

    [NativeTypeName("bool")]
    public byte EnableColorWriteMask;

    [NativeTypeName("Uint8")]
    public byte Padding1;

    [NativeTypeName("Uint8")]
    public byte Padding2;
}
