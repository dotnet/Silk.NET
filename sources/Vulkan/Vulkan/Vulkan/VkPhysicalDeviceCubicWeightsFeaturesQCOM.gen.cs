// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceCubicWeightsFeaturesQCOM
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    public void* pNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    public uint selectableCubicWeights;
}
