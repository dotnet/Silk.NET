// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUGraphicsPipelineCreateInfo")]
public unsafe partial struct GpuGraphicsPipelineCreateInfo
{
    [NativeName("vertex_shader")]
    public GpuShaderHandle VertexShader;

    [NativeName("fragment_shader")]
    public GpuShaderHandle FragmentShader;

    [NativeName("vertex_input_state")]
    public GpuVertexInputState VertexInputState;

    [NativeName("primitive_type")]
    public GpuPrimitiveType PrimitiveType;

    [NativeName("rasterizer_state")]
    public GpuRasterizerState RasterizerState;

    [NativeName("multisample_state")]
    public GpuMultisampleState MultisampleState;

    [NativeName("depth_stencil_state")]
    public GpuDepthStencilState DepthStencilState;

    [NativeName("target_info")]
    public GpuGraphicsPipelineTargetInfo TargetInfo;

    [NativeName("props")]
    public uint Props;
}
