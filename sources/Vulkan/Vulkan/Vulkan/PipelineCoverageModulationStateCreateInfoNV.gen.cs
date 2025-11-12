// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PipelineCoverageModulationStateCreateInfoNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    public void* PNext;

    [NativeTypeName("VkPipelineCoverageModulationStateCreateFlagsNV")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    public uint Flags;

    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    public CoverageModulationModeNV CoverageModulationMode;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    public MaybeBool<uint> CoverageModulationTableEnable;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    public uint CoverageModulationTableCount;

    [NativeTypeName("const float *")]
    [SupportedApiProfile("vulkan", ["VK_NV_framebuffer_mixed_samples"])]
    public float* PCoverageModulationTable;
}
