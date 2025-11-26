// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

public unsafe partial struct GPUGraphicsPipelineCreateInfo
{
    public GPUShaderHandle VertexShader;
    public GPUShaderHandle FragmentShader;
    public GPUVertexInputState VertexInputState;
    public GPUPrimitiveType PrimitiveType;
    public GPURasterizerState RasterizerState;
    public GPUMultisampleState MultisampleState;
    public GPUDepthStencilState DepthStencilState;
    public GPUGraphicsPipelineTargetInfo TargetInfo;

    [NativeTypeName("SDL_PropertiesID")]
    public uint Props;
}
