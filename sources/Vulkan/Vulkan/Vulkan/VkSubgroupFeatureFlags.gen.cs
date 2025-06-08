// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkSubgroupFeatureFlags
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_SUBGROUP_FEATURE_BASIC_BIT = 0x00000001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_SUBGROUP_FEATURE_VOTE_BIT = 0x00000002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_SUBGROUP_FEATURE_ARITHMETIC_BIT = 0x00000004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_SUBGROUP_FEATURE_BALLOT_BIT = 0x00000008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_SUBGROUP_FEATURE_SHUFFLE_BIT = 0x00000010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT = 0x00000020,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_SUBGROUP_FEATURE_CLUSTERED_BIT = 0x00000040,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_SUBGROUP_FEATURE_QUAD_BIT = 0x00000080,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_SUBGROUP_FEATURE_ROTATE_BIT = 0x00000200,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_SUBGROUP_FEATURE_ROTATE_CLUSTERED_BIT = 0x00000400,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shader_subgroup_partitioned"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    VK_SUBGROUP_FEATURE_PARTITIONED_BIT_NV = 0x00000100,

    [SupportedApiProfile("vulkan", ["VK_KHR_shader_subgroup_rotate"])]
    VK_SUBGROUP_FEATURE_ROTATE_BIT_KHR = VK_SUBGROUP_FEATURE_ROTATE_BIT,

    [SupportedApiProfile("vulkan", ["VK_KHR_shader_subgroup_rotate"])]
    VK_SUBGROUP_FEATURE_ROTATE_CLUSTERED_BIT_KHR = VK_SUBGROUP_FEATURE_ROTATE_CLUSTERED_BIT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    VK_SUBGROUP_FEATURE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
}
