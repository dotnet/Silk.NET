// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPURasterizerState")]
public partial struct GPURasterizerState
{
    [NativeName("fill_mode")]
    public GPUFillMode FillMode;

    [NativeName("cull_mode")]
    public GPUCullMode CullMode;

    [NativeName("front_face")]
    public GPUFrontFace FrontFace;

    [NativeName("depth_bias_constant_factor")]
    public float DepthBiasConstantFactor;

    [NativeName("depth_bias_clamp")]
    public float DepthBiasClamp;

    [NativeName("depth_bias_slope_factor")]
    public float DepthBiasSlopeFactor;

    [NativeName("enable_depth_bias")]
    public byte EnableDepthBias;

    [NativeName("enable_depth_clip")]
    public byte EnableDepthClip;

    [NativeName("padding1")]
    public byte Padding1;

    [NativeName("padding2")]
    public byte Padding2;
}
