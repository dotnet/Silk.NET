// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineDepthStencilStateCreateInfo")]
public unsafe partial struct PipelineDepthStencilStateCreateInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PipelineDepthStencilStateCreateInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public PipelineDepthStencilStateCreateFlags Flags;

    [NativeName("depthTestEnable")]
    public MaybeBool<uint> DepthTestEnable;

    [NativeName("depthWriteEnable")]
    public MaybeBool<uint> DepthWriteEnable;

    [NativeName("depthCompareOp")]
    public CompareOp DepthCompareOp;

    [NativeName("depthBoundsTestEnable")]
    public MaybeBool<uint> DepthBoundsTestEnable;

    [NativeName("stencilTestEnable")]
    public MaybeBool<uint> StencilTestEnable;

    [NativeName("front")]
    public StencilOpState Front;

    [NativeName("back")]
    public StencilOpState Back;

    [NativeName("minDepthBounds")]
    public float MinDepthBounds;

    [NativeName("maxDepthBounds")]
    public float MaxDepthBounds;

    public PipelineDepthStencilStateCreateInfo() { }
}
