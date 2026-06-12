// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceCooperativeMatrix2FeaturesNV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceCooperativeMatrix2FeaturesNV
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public StructureType SType = StructureType.PhysicalDeviceCooperativeMatrix2FeaturesNV;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public void* PNext;

    [NativeName("cooperativeMatrixWorkgroupScope")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public MaybeBool<uint> CooperativeMatrixWorkgroupScope;

    [NativeName("cooperativeMatrixFlexibleDimensions")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public MaybeBool<uint> CooperativeMatrixFlexibleDimensions;

    [NativeName("cooperativeMatrixReductions")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public MaybeBool<uint> CooperativeMatrixReductions;

    [NativeName("cooperativeMatrixConversions")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public MaybeBool<uint> CooperativeMatrixConversions;

    [NativeName("cooperativeMatrixPerElementOperations")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public MaybeBool<uint> CooperativeMatrixPerElementOperations;

    [NativeName("cooperativeMatrixTensorAddressing")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public MaybeBool<uint> CooperativeMatrixTensorAddressing;

    [NativeName("cooperativeMatrixBlockLoads")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public MaybeBool<uint> CooperativeMatrixBlockLoads;

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public PhysicalDeviceCooperativeMatrix2FeaturesNV() { }
}
