// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineRasterizationStateCreateInfo")]
public unsafe partial struct PipelineRasterizationStateCreateInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PipelineRasterizationStateCreateInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public uint Flags;

    [NativeName("depthClampEnable")]
    public MaybeBool<uint> DepthClampEnable;

    [NativeName("rasterizerDiscardEnable")]
    public MaybeBool<uint> RasterizerDiscardEnable;

    [NativeName("polygonMode")]
    public PolygonMode PolygonMode;

    [NativeName("cullMode")]
    public CullModeFlags CullMode;

    [NativeName("frontFace")]
    public FrontFace FrontFace;

    [NativeName("depthBiasEnable")]
    public MaybeBool<uint> DepthBiasEnable;

    [NativeName("depthBiasConstantFactor")]
    public float DepthBiasConstantFactor;

    [NativeName("depthBiasClamp")]
    public float DepthBiasClamp;

    [NativeName("depthBiasSlopeFactor")]
    public float DepthBiasSlopeFactor;

    [NativeName("lineWidth")]
    public float LineWidth;

    public PipelineRasterizationStateCreateInfo() { }
}
