// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkDriverId : uint
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_AMD_PROPRIETARY = 1,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_AMD_OPEN_SOURCE = 2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_MESA_RADV = 3,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_NVIDIA_PROPRIETARY = 4,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS = 5,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA = 6,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_IMAGINATION_PROPRIETARY = 7,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_QUALCOMM_PROPRIETARY = 8,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_ARM_PROPRIETARY = 9,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_GOOGLE_SWIFTSHADER = 10,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_GGP_PROPRIETARY = 11,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_BROADCOM_PROPRIETARY = 12,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_MESA_LLVMPIPE = 13,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_MOLTENVK = 14,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_COREAVI_PROPRIETARY = 15,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_JUICE_PROPRIETARY = 16,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_VERISILICON_PROPRIETARY = 17,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_MESA_TURNIP = 18,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_MESA_V3DV = 19,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_MESA_PANVK = 20,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_SAMSUNG_PROPRIETARY = 21,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_MESA_VENUS = 22,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_MESA_DOZEN = 23,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_MESA_NVK = 24,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_IMAGINATION_OPEN_SOURCE_MESA = 25,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_MESA_HONEYKRISP = 26,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_VULKAN_SC_EMULATION_ON_VULKAN = 27,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    VK_DRIVER_ID_AMD_PROPRIETARY_KHR = VK_DRIVER_ID_AMD_PROPRIETARY,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    VK_DRIVER_ID_AMD_OPEN_SOURCE_KHR = VK_DRIVER_ID_AMD_OPEN_SOURCE,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    VK_DRIVER_ID_MESA_RADV_KHR = VK_DRIVER_ID_MESA_RADV,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    VK_DRIVER_ID_NVIDIA_PROPRIETARY_KHR = VK_DRIVER_ID_NVIDIA_PROPRIETARY,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS_KHR = VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA_KHR = VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    VK_DRIVER_ID_IMAGINATION_PROPRIETARY_KHR = VK_DRIVER_ID_IMAGINATION_PROPRIETARY,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    VK_DRIVER_ID_QUALCOMM_PROPRIETARY_KHR = VK_DRIVER_ID_QUALCOMM_PROPRIETARY,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    VK_DRIVER_ID_ARM_PROPRIETARY_KHR = VK_DRIVER_ID_ARM_PROPRIETARY,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    VK_DRIVER_ID_GOOGLE_SWIFTSHADER_KHR = VK_DRIVER_ID_GOOGLE_SWIFTSHADER,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    VK_DRIVER_ID_GGP_PROPRIETARY_KHR = VK_DRIVER_ID_GGP_PROPRIETARY,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    VK_DRIVER_ID_BROADCOM_PROPRIETARY_KHR = VK_DRIVER_ID_BROADCOM_PROPRIETARY,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_DRIVER_ID_MAX_ENUM = 0x7FFFFFFF,
}
