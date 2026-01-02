// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct ShaderStatisticsInfoAMD
{
    [NativeTypeName("VkShaderStageFlags")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public ShaderStageFlags ShaderStageMask;

    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public ShaderResourceUsageAMD ResourceUsage;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint NumPhysicalVgprs;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint NumPhysicalSgprs;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint NumAvailableVgprs;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint NumAvailableSgprs;

    [NativeTypeName("uint32_t[3]")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public ShaderStatisticsInfoAMDComputeWorkGroupSize ComputeWorkGroupSize;
}
