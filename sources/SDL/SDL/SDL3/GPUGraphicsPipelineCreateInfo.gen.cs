// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUGraphicsPipelineCreateInfo")]
public unsafe partial struct GPUGraphicsPipelineCreateInfo
{
    [NativeName("vertex_shader")]
    public GPUShaderHandle VertexShader;

    [NativeName("fragment_shader")]
    public GPUShaderHandle FragmentShader;

    [NativeName("vertex_input_state")]
    public GPUVertexInputState VertexInputState;

    [NativeName("primitive_type")]
    public GPUPrimitiveType PrimitiveType;

    [NativeName("rasterizer_state")]
    public GPURasterizerState RasterizerState;

    [NativeName("multisample_state")]
    public GPUMultisampleState MultisampleState;

    [NativeName("depth_stencil_state")]
    public GPUDepthStencilState DepthStencilState;

    [NativeName("target_info")]
    public GPUGraphicsPipelineTargetInfo TargetInfo;

    [NativeName("props")]
    public uint Props;
}
