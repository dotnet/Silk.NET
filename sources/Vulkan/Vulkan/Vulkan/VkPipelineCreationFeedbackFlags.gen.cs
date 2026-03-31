// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineCreationFeedbackFlagBits")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkPipelineCreationFeedbackFlags : uint
{
    [NativeName("VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkPipelineCreationFeedbackValidBit = 0x00000001,

    [NativeName("VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkPipelineCreationFeedbackApplicationPipelineCacheHitBit = 0x00000002,

    [NativeName("VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkPipelineCreationFeedbackBasePipelineAccelerationBit = 0x00000004,

    [NativeName("VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_pipeline_creation_feedback"])]
    VkPipelineCreationFeedbackValidBitEXT = VkPipelineCreationFeedbackValidBit,

    [NativeName("VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_pipeline_creation_feedback"])]
    VkPipelineCreationFeedbackApplicationPipelineCacheHitBitEXT =
        VkPipelineCreationFeedbackApplicationPipelineCacheHitBit,

    [NativeName("VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_pipeline_creation_feedback"])]
    VkPipelineCreationFeedbackBasePipelineAccelerationBitEXT =
        VkPipelineCreationFeedbackBasePipelineAccelerationBit,

    [NativeName("VK_PIPELINE_CREATION_FEEDBACK_FLAG_BITS_MAX_ENUM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkPipelineCreationFeedbackFlagBitsMaxEnum = 0x7FFFFFFF,
}
