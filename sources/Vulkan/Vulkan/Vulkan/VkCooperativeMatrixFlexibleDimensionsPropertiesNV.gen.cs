// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkCooperativeMatrixFlexibleDimensionsPropertiesNV
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public void* pNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public uint MGranularity;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public uint NGranularity;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public uint KGranularity;

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public VkComponentTypeKHR AType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public VkComponentTypeKHR BType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public VkComponentTypeKHR CType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public VkComponentTypeKHR ResultType;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public uint saturatingAccumulation;

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public VkScopeKHR scope;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cooperative_matrix2"],
        ImpliesSets = ["VK_KHR_cooperative_matrix"]
    )]
    public uint workgroupInvocations;
}
