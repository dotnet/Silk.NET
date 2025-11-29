// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkSubpassMergeStatusEXT")]
[SupportedApiProfile("vulkan")]
public enum SubpassMergeStatusEXT : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_SUBPASS_MERGE_STATUS_MERGED_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    MergedEXT = 0,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_SUBPASS_MERGE_STATUS_DISALLOWED_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    DisallowedEXT = 1,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SIDE_EFFECTS_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    NotMergedSideEffectsEXT = 2,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SAMPLES_MISMATCH_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    NotMergedSamplesMismatchEXT = 3,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_SUBPASS_MERGE_STATUS_NOT_MERGED_VIEWS_MISMATCH_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    NotMergedViewsMismatchEXT = 4,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_SUBPASS_MERGE_STATUS_NOT_MERGED_ALIASING_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    NotMergedAliasingEXT = 5,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_SUBPASS_MERGE_STATUS_NOT_MERGED_DEPENDENCIES_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    NotMergedDependenciesEXT = 6,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_SUBPASS_MERGE_STATUS_NOT_MERGED_INCOMPATIBLE_INPUT_ATTACHMENT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    NotMergedIncompatibleInputAttachmentEXT = 7,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_SUBPASS_MERGE_STATUS_NOT_MERGED_TOO_MANY_ATTACHMENTS_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    NotMergedTooManyAttachmentsEXT = 8,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_SUBPASS_MERGE_STATUS_NOT_MERGED_INSUFFICIENT_STORAGE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    NotMergedInsufficientStorageEXT = 9,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_SUBPASS_MERGE_STATUS_NOT_MERGED_DEPTH_STENCIL_COUNT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    NotMergedDepthStencilCountEXT = 10,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_SUBPASS_MERGE_STATUS_NOT_MERGED_RESOLVE_ATTACHMENT_REUSE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    NotMergedResolveAttachmentReuseEXT = 11,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SINGLE_SUBPASS_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    NotMergedSingleSubpassEXT = 12,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_SUBPASS_MERGE_STATUS_NOT_MERGED_UNSPECIFIED_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_subpass_merge_feedback"],
        ImpliesSets = [
            "VK_EXT_subpass_merge_feedback+VK_KHR_get_physical_device_properties2",
            "VK_EXT_subpass_merge_feedback+VK_VERSION_1_1",
        ]
    )]
    NotMergedUnspecifiedEXT = 13,
}
