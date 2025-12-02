// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCooperativeMatrixPropertiesNV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct CooperativeMatrixPropertiesNV
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("MSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    public uint MSize;

    [NativeName("NSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    public uint NSize;

    [NativeName("KSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    public uint KSize;

    [NativeName("AType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    public ComponentType AType;

    [NativeName("BType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    public ComponentType BType;

    [NativeName("CType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    public ComponentType CType;

    [NativeName("DType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    public ComponentType DType;

    [NativeName("scope")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix"],
        ImpliesSets = [
            "VK_NV_cooperative_matrix+VK_KHR_get_physical_device_properties2",
            "VK_NV_cooperative_matrix+VK_VERSION_1_1",
        ]
    )]
    public Scope Scope;
}
