// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPipelineCoverageModulationStateCreateInfoNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    public void* pNext;

    [NativeTypeName("VkPipelineCoverageModulationStateCreateFlagsNV")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    public uint flags;

    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    public VkCoverageModulationModeNV coverageModulationMode;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    public uint coverageModulationTableEnable;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    public uint coverageModulationTableCount;

    [NativeTypeName("const float *")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    public float* pCoverageModulationTable;
}
