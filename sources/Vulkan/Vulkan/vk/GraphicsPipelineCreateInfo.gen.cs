// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkGraphicsPipelineCreateInfo")]
public unsafe partial struct GraphicsPipelineCreateInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.GraphicsPipelineCreateInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public PipelineCreateFlags Flags;

    [NativeName("stageCount")]
    public uint StageCount;

    [NativeName("pStages")]
    public PipelineShaderStageCreateInfo* PStages;

    [NativeName("pVertexInputState")]
    public PipelineVertexInputStateCreateInfo* PVertexInputState;

    [NativeName("pInputAssemblyState")]
    public PipelineInputAssemblyStateCreateInfo* PInputAssemblyState;

    [NativeName("pTessellationState")]
    public PipelineTessellationStateCreateInfo* PTessellationState;

    [NativeName("pViewportState")]
    public PipelineViewportStateCreateInfo* PViewportState;

    [NativeName("pRasterizationState")]
    public PipelineRasterizationStateCreateInfo* PRasterizationState;

    [NativeName("pMultisampleState")]
    public PipelineMultisampleStateCreateInfo* PMultisampleState;

    [NativeName("pDepthStencilState")]
    public PipelineDepthStencilStateCreateInfo* PDepthStencilState;

    [NativeName("pColorBlendState")]
    public PipelineColorBlendStateCreateInfo* PColorBlendState;

    [NativeName("pDynamicState")]
    public PipelineDynamicStateCreateInfo* PDynamicState;

    [NativeName("layout")]
    public PipelineLayoutHandle Layout;

    [NativeName("renderPass")]
    public RenderPassHandle RenderPass;

    [NativeName("subpass")]
    public uint Subpass;

    [NativeName("basePipelineHandle")]
    public PipelineHandle BasePipelineHandle;

    [NativeName("basePipelineIndex")]
    public int BasePipelineIndex;

    public GraphicsPipelineCreateInfo() { }
}
