// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSubpassMergeStatusEXT")]
    public enum SubpassMergeStatusEXT : int
    {
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_MERGED_EXT")]
        SubpassMergeStatusMergedExt = 0,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_DISALLOWED_EXT")]
        SubpassMergeStatusDisallowedExt = 1,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SIDE_EFFECTS_EXT")]
        SubpassMergeStatusNotMergedSideEffectsExt = 2,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SAMPLES_MISMATCH_EXT")]
        SubpassMergeStatusNotMergedSamplesMismatchExt = 3,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_VIEWS_MISMATCH_EXT")]
        SubpassMergeStatusNotMergedViewsMismatchExt = 4,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_ALIASING_EXT")]
        SubpassMergeStatusNotMergedAliasingExt = 5,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_DEPENDENCIES_EXT")]
        SubpassMergeStatusNotMergedDependenciesExt = 6,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_INCOMPATIBLE_INPUT_ATTACHMENT_EXT")]
        SubpassMergeStatusNotMergedIncompatibleInputAttachmentExt = 7,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_TOO_MANY_ATTACHMENTS_EXT")]
        SubpassMergeStatusNotMergedTooManyAttachmentsExt = 8,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_INSUFFICIENT_STORAGE_EXT")]
        SubpassMergeStatusNotMergedInsufficientStorageExt = 9,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_DEPTH_STENCIL_COUNT_EXT")]
        SubpassMergeStatusNotMergedDepthStencilCountExt = 10,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_RESOLVE_ATTACHMENT_REUSE_EXT")]
        SubpassMergeStatusNotMergedResolveAttachmentReuseExt = 11,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SINGLE_SUBPASS_EXT")]
        SubpassMergeStatusNotMergedSingleSubpassExt = 12,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_UNSPECIFIED_EXT")]
        SubpassMergeStatusNotMergedUnspecifiedExt = 13,
    }
}
