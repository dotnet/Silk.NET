// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("NV", 0)]
[NativeName("VkPipelineCoverageModulationStateCreateInfoNV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PipelineCoverageModulationStateCreateInfoNV
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    public void* PNext;

    [NativeName("flags")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    public uint Flags;

    [NativeName("coverageModulationMode")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    public CoverageModulationModeNV CoverageModulationMode;

    [NativeName("coverageModulationTableEnable")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    public uint CoverageModulationTableEnable;

    [NativeName("coverageModulationTableCount")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    public uint CoverageModulationTableCount;

    [NativeName("pCoverageModulationTable")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    public float* PCoverageModulationTable;
}
