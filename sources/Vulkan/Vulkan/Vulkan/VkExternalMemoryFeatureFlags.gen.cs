// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkExternalMemoryFeatureFlagBits")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkExternalMemoryFeatureFlags : uint
{
    [NativeName("VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkExternalMemoryFeatureDedicatedOnlyBit = 0x00000001,

    [NativeName("VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkExternalMemoryFeatureExportableBit = 0x00000002,

    [NativeName("VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkExternalMemoryFeatureImportableBit = 0x00000004,

    [NativeName("VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_memory_capabilities+VK_VERSION_1_1",
        ]
    )]
    VkExternalMemoryFeatureDedicatedOnlyBitKHR = VkExternalMemoryFeatureDedicatedOnlyBit,

    [NativeName("VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_memory_capabilities+VK_VERSION_1_1",
        ]
    )]
    VkExternalMemoryFeatureExportableBitKHR = VkExternalMemoryFeatureExportableBit,

    [NativeName("VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_capabilities"],
        ImpliesSets = [
            "VK_KHR_external_memory_capabilities+VK_KHR_get_physical_device_properties2",
            "VK_KHR_external_memory_capabilities+VK_VERSION_1_1",
        ]
    )]
    VkExternalMemoryFeatureImportableBitKHR = VkExternalMemoryFeatureImportableBit,

    [NativeName("VK_EXTERNAL_MEMORY_FEATURE_FLAG_BITS_MAX_ENUM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    VkExternalMemoryFeatureFlagBitsMaxEnum = 0x7FFFFFFF,
}
