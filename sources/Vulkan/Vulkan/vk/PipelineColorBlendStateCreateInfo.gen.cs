// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineColorBlendStateCreateInfo")]
public unsafe partial struct PipelineColorBlendStateCreateInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PipelineColorBlendStateCreateInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public PipelineColorBlendStateCreateFlags Flags;

    [NativeName("logicOpEnable")]
    public MaybeBool<uint> LogicOpEnable;

    [NativeName("logicOp")]
    public LogicOp LogicOp;

    [NativeName("attachmentCount")]
    public uint AttachmentCount;

    [NativeName("pAttachments")]
    public PipelineColorBlendAttachmentState* PAttachments;

    [NativeName("blendConstants")]
    public PipelineColorBlendStateCreateInfoBlendConstants BlendConstants;

    public PipelineColorBlendStateCreateInfo() { }
}
