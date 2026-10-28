// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkRayTracingPipelineCreateInfoKHR")]
public unsafe partial struct RayTracingPipelineCreateInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.RayTracingPipelineCreateInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public PipelineCreateFlags Flags;

    [NativeName("stageCount")]
    public uint StageCount;

    [NativeName("pStages")]
    public PipelineShaderStageCreateInfo* PStages;

    [NativeName("groupCount")]
    public uint GroupCount;

    [NativeName("pGroups")]
    public RayTracingShaderGroupCreateInfoKHR* PGroups;

    [NativeName("maxPipelineRayRecursionDepth")]
    public uint MaxPipelineRayRecursionDepth;

    [NativeName("pLibraryInfo")]
    public PipelineLibraryCreateInfoKHR* PLibraryInfo;

    [NativeName("pLibraryInterface")]
    public RayTracingPipelineInterfaceCreateInfoKHR* PLibraryInterface;

    [NativeName("pDynamicState")]
    public PipelineDynamicStateCreateInfo* PDynamicState;

    [NativeName("layout")]
    public PipelineLayoutHandle Layout;

    [NativeName("basePipelineHandle")]
    public PipelineHandle BasePipelineHandle;

    [NativeName("basePipelineIndex")]
    public int BasePipelineIndex;

    public RayTracingPipelineCreateInfoKHR() { }
}
