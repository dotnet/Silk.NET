// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkPipelineCreationFeedbackFlags
{
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT = 0x00000001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT = 0x00000002,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT = 0x00000004,

    [SupportedApiProfile("vulkan", ["VK_EXT_pipeline_creation_feedback"])]
    VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT_EXT = VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT,

    [SupportedApiProfile("vulkan", ["VK_EXT_pipeline_creation_feedback"])]
    VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT_EXT =
        VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT,

    [SupportedApiProfile("vulkan", ["VK_EXT_pipeline_creation_feedback"])]
    VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT_EXT =
        VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_PIPELINE_CREATION_FEEDBACK_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
}
