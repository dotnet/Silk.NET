// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceImageProcessing2FeaturesQCOM
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing2"],
        ImpliesSets = ["VK_QCOM_image_processing"]
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing2"],
        ImpliesSets = ["VK_QCOM_image_processing"]
    )]
    public void* pNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing2"],
        ImpliesSets = ["VK_QCOM_image_processing"]
    )]
    public uint textureBlockMatch2;
}
