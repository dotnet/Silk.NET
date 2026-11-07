// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSubpassMergeStatusEXT")]
public enum SubpassMergeStatusEXT : uint
{
    [NativeName("VK_SUBPASS_MERGE_STATUS_MERGED_EXT")]
    Merged = 0,

    [NativeName("VK_SUBPASS_MERGE_STATUS_DISALLOWED_EXT")]
    Disallowed = 1,

    [NativeName("VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SIDE_EFFECTS_EXT")]
    NotMergedSideEffects = 2,

    [NativeName("VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SAMPLES_MISMATCH_EXT")]
    NotMergedSamplesMismatch = 3,

    [NativeName("VK_SUBPASS_MERGE_STATUS_NOT_MERGED_VIEWS_MISMATCH_EXT")]
    NotMergedViewsMismatch = 4,

    [NativeName("VK_SUBPASS_MERGE_STATUS_NOT_MERGED_ALIASING_EXT")]
    NotMergedAliasing = 5,

    [NativeName("VK_SUBPASS_MERGE_STATUS_NOT_MERGED_DEPENDENCIES_EXT")]
    NotMergedDependencies = 6,

    [NativeName("VK_SUBPASS_MERGE_STATUS_NOT_MERGED_INCOMPATIBLE_INPUT_ATTACHMENT_EXT")]
    NotMergedIncompatibleInputAttachment = 7,

    [NativeName("VK_SUBPASS_MERGE_STATUS_NOT_MERGED_TOO_MANY_ATTACHMENTS_EXT")]
    NotMergedTooManyAttachments = 8,

    [NativeName("VK_SUBPASS_MERGE_STATUS_NOT_MERGED_INSUFFICIENT_STORAGE_EXT")]
    NotMergedInsufficientStorage = 9,

    [NativeName("VK_SUBPASS_MERGE_STATUS_NOT_MERGED_DEPTH_STENCIL_COUNT_EXT")]
    NotMergedDepthStencilCount = 10,

    [NativeName("VK_SUBPASS_MERGE_STATUS_NOT_MERGED_RESOLVE_ATTACHMENT_REUSE_EXT")]
    NotMergedResolveAttachmentReuse = 11,

    [NativeName("VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SINGLE_SUBPASS_EXT")]
    NotMergedSingleSubpass = 12,

    [NativeName("VK_SUBPASS_MERGE_STATUS_NOT_MERGED_UNSPECIFIED_EXT")]
    NotMergedUnspecified = 13,
}
