// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkShaderStatisticsInfoAMD")]
public partial struct ShaderStatisticsInfoAMD
{
    [NativeName("shaderStageMask")]
    public ShaderStageFlags ShaderStageMask;

    [NativeName("resourceUsage")]
    public ShaderResourceUsageAMD ResourceUsage;

    [NativeName("numPhysicalVgprs")]
    public uint NumPhysicalVgprs;

    [NativeName("numPhysicalSgprs")]
    public uint NumPhysicalSgprs;

    [NativeName("numAvailableVgprs")]
    public uint NumAvailableVgprs;

    [NativeName("numAvailableSgprs")]
    public uint NumAvailableSgprs;

    [NativeName("computeWorkGroupSize")]
    public ShaderStatisticsInfoAMDComputeWorkGroupSize ComputeWorkGroupSize;
}
