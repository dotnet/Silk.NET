// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUStencilOpState")]
public partial struct GPUStencilOpState
{
    [NativeName("fail_op")]
    public GPUStencilOp FailOp;

    [NativeName("pass_op")]
    public GPUStencilOp PassOp;

    [NativeName("depth_fail_op")]
    public GPUStencilOp DepthFailOp;

    [NativeName("compare_op")]
    public GPUCompareOp CompareOp;
}
