// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceCooperativeMatrix2PropertiesNV")]
[NameAffix("Suffix", "KhronosVendor", "NV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceCooperativeMatrix2PropertiesNV
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public void* PNext;

    [NativeName("cooperativeMatrixWorkgroupScopeMaxWorkgroupSize")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public uint CooperativeMatrixWorkgroupScopeMaxWorkgroupSize;

    [NativeName("cooperativeMatrixFlexibleDimensionsMaxDimension")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public uint CooperativeMatrixFlexibleDimensionsMaxDimension;

    [NativeName("cooperativeMatrixWorkgroupScopeReservedSharedMemory")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public uint CooperativeMatrixWorkgroupScopeReservedSharedMemory;
}
