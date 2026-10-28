// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCommandBufferInheritanceInfo")]
public unsafe partial struct CommandBufferInheritanceInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.CommandBufferInheritanceInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("renderPass")]
    public RenderPassHandle RenderPass;

    [NativeName("subpass")]
    public uint Subpass;

    [NativeName("framebuffer")]
    public FramebufferHandle Framebuffer;

    [NativeName("occlusionQueryEnable")]
    public MaybeBool<uint> OcclusionQueryEnable;

    [NativeName("queryFlags")]
    public QueryControlFlags QueryFlags;

    [NativeName("pipelineStatistics")]
    public QueryPipelineStatisticFlags PipelineStatistics;

    public CommandBufferInheritanceInfo() { }
}
