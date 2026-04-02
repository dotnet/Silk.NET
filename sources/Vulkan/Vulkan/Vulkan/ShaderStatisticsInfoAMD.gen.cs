// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkShaderStatisticsInfoAMD")]
[SupportedApiProfile("vulkan")]
public partial struct ShaderStatisticsInfoAMD
{
    [NativeName("shaderStageMask")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public ShaderStageFlags ShaderStageMask;

    [NativeName("resourceUsage")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public ShaderResourceUsageAMD ResourceUsage;

    [NativeName("numPhysicalVgprs")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint NumPhysicalVgprs;

    [NativeName("numPhysicalSgprs")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint NumPhysicalSgprs;

    [NativeName("numAvailableVgprs")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint NumAvailableVgprs;

    [NativeName("numAvailableSgprs")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint NumAvailableSgprs;

    [NativeName("computeWorkGroupSize")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public ShaderStatisticsInfoAMDComputeWorkGroupSize ComputeWorkGroupSize;
}
