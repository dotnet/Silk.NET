// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

public unsafe partial struct GpuGraphicsPipelineCreateInfo
{
    public GpuShaderHandle VertexShader;
    public GpuShaderHandle FragmentShader;
    public GpuVertexInputState VertexInputState;
    public GpuPrimitiveType PrimitiveType;
    public GpuRasterizerState RasterizerState;
    public GpuMultisampleState MultisampleState;
    public GpuDepthStencilState DepthStencilState;
    public GpuGraphicsPipelineTargetInfo TargetInfo;

    [NativeTypeName("SDL_PropertiesID")]
    public uint Props;
}
