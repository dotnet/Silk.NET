// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkShaderStatisticsInfoAMD")]
[NameAffix("Suffix", "KhronosVendor", "AMD")]
[SupportedApiProfile("vulkan")]
public partial struct VkShaderStatisticsInfoAMD
{
    [NativeName("shaderStageMask")]
    [NativeTypeName("VkShaderStageFlags")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public VkShaderStageFlags ShaderStageMask;

    [NativeName("resourceUsage")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public VkShaderResourceUsageAMD ResourceUsage;

    [NativeName("numPhysicalVgprs")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint NumPhysicalVgprs;

    [NativeName("numPhysicalSgprs")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint NumPhysicalSgprs;

    [NativeName("numAvailableVgprs")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint NumAvailableVgprs;

    [NativeName("numAvailableSgprs")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint NumAvailableSgprs;

    [NativeName("computeWorkGroupSize")]
    [NativeTypeName("uint32_t[3]")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public VkShaderStatisticsInfoAMDComputeWorkGroupSize ComputeWorkGroupSize;
}
