// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceImageProcessingFeaturesQCOM
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing"],
        ImpliesSets = [
            "VK_QCOM_image_processing+VK_KHR_format_feature_flags2",
            "VK_QCOM_image_processing+VK_VERSION_1_3",
        ]
    )]
    public StructureType SType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing"],
        ImpliesSets = [
            "VK_QCOM_image_processing+VK_KHR_format_feature_flags2",
            "VK_QCOM_image_processing+VK_VERSION_1_3",
        ]
    )]
    public void* PNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing"],
        ImpliesSets = [
            "VK_QCOM_image_processing+VK_KHR_format_feature_flags2",
            "VK_QCOM_image_processing+VK_VERSION_1_3",
        ]
    )]
    public MaybeBool<uint> TextureSampleWeighted;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing"],
        ImpliesSets = [
            "VK_QCOM_image_processing+VK_KHR_format_feature_flags2",
            "VK_QCOM_image_processing+VK_VERSION_1_3",
        ]
    )]
    public MaybeBool<uint> TextureBoxFilter;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing"],
        ImpliesSets = [
            "VK_QCOM_image_processing+VK_KHR_format_feature_flags2",
            "VK_QCOM_image_processing+VK_VERSION_1_3",
        ]
    )]
    public MaybeBool<uint> TextureBlockMatch;
}
