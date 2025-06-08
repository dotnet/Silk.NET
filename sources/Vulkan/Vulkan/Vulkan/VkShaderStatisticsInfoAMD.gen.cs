// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct VkShaderStatisticsInfoAMD
{
    [NativeTypeName("VkShaderStageFlags")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint shaderStageMask;

    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public VkShaderResourceUsageAMD resourceUsage;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint numPhysicalVgprs;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint numPhysicalSgprs;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint numAvailableVgprs;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint numAvailableSgprs;

    [NativeTypeName("uint32_t[3]")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public VkShaderStatisticsInfoAMD_computeWorkGroupSize computeWorkGroupSize;
}
