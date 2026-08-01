// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceImageProcessing3FeaturesQCOM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceImageProcessing3FeaturesQCOM
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing3"],
        ImpliesSets = [
            "VK_QCOM_image_processing3+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_image_processing3+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType = StructureType.PhysicalDeviceImageProcessing3FeaturesQCOM;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing3"],
        ImpliesSets = [
            "VK_QCOM_image_processing3+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_image_processing3+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("imageGatherLinear")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing3"],
        ImpliesSets = [
            "VK_QCOM_image_processing3+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_image_processing3+VK_VERSION_1_1",
        ]
    )]
    public MaybeBool<uint> ImageGatherLinear;

    [NativeName("imageGatherExtendedModes")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing3"],
        ImpliesSets = [
            "VK_QCOM_image_processing3+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_image_processing3+VK_VERSION_1_1",
        ]
    )]
    public MaybeBool<uint> ImageGatherExtendedModes;

    [NativeName("blockMatchExtendedClampToEdge")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing3"],
        ImpliesSets = [
            "VK_QCOM_image_processing3+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_image_processing3+VK_VERSION_1_1",
        ]
    )]
    public MaybeBool<uint> BlockMatchExtendedClampToEdge;

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing3"],
        ImpliesSets = [
            "VK_QCOM_image_processing3+VK_KHR_get_physical_device_properties2",
            "VK_QCOM_image_processing3+VK_VERSION_1_1",
        ]
    )]
    public PhysicalDeviceImageProcessing3FeaturesQCOM() { }
}
