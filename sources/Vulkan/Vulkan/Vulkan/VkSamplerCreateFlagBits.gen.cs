// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
[Flags]
public enum SamplerCreateFlags : uint
{
    None = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    SubsampledBitEXT = 0x00000001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_fragment_density_map"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_fragment_density_map+VK_VERSION_1_1",
        ]
    )]
    SubsampledCoarseReconstructionBitEXT = 0x00000002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_buffer"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_KHR_buffer_device_address+VK_EXT_descriptor_indexing+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    DescriptorBufferCaptureReplayBitEXT = 0x00000008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_non_seamless_cube_map"],
        ImpliesSets = [
            "VK_EXT_non_seamless_cube_map+VK_KHR_get_physical_device_properties2",
            "VK_EXT_non_seamless_cube_map+VK_VERSION_1_1",
        ]
    )]
    NonSeamlessCubeMapBitEXT = 0x00000004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing"],
        ImpliesSets = [
            "VK_QCOM_image_processing+VK_KHR_format_feature_flags2",
            "VK_QCOM_image_processing+VK_VERSION_1_3",
        ]
    )]
    ImageProcessingBitQCOM = 0x00000010,
}
