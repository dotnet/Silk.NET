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
        [Obsolete("Deprecated in favour of \"MergedExt\"")]
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_MERGED_EXT")]
        SubpassMergeStatusMergedExt = 0,
        [Obsolete("Deprecated in favour of \"DisallowedExt\"")]
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_DISALLOWED_EXT")]
        SubpassMergeStatusDisallowedExt = 1,
        [Obsolete("Deprecated in favour of \"NotMergedSideEffectsExt\"")]
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SIDE_EFFECTS_EXT")]
        SubpassMergeStatusNotMergedSideEffectsExt = 2,
        [Obsolete("Deprecated in favour of \"NotMergedSamplesMismatchExt\"")]
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SAMPLES_MISMATCH_EXT")]
        SubpassMergeStatusNotMergedSamplesMismatchExt = 3,
        [Obsolete("Deprecated in favour of \"NotMergedViewsMismatchExt\"")]
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_VIEWS_MISMATCH_EXT")]
        SubpassMergeStatusNotMergedViewsMismatchExt = 4,
        [Obsolete("Deprecated in favour of \"NotMergedAliasingExt\"")]
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_ALIASING_EXT")]
        SubpassMergeStatusNotMergedAliasingExt = 5,
        [Obsolete("Deprecated in favour of \"NotMergedDependenciesExt\"")]
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_DEPENDENCIES_EXT")]
        SubpassMergeStatusNotMergedDependenciesExt = 6,
        [Obsolete("Deprecated in favour of \"NotMergedIncompatibleInputAttachmentExt\"")]
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_INCOMPATIBLE_INPUT_ATTACHMENT_EXT")]
        SubpassMergeStatusNotMergedIncompatibleInputAttachmentExt = 7,
        [Obsolete("Deprecated in favour of \"NotMergedTooManyAttachmentsExt\"")]
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_TOO_MANY_ATTACHMENTS_EXT")]
        SubpassMergeStatusNotMergedTooManyAttachmentsExt = 8,
        [Obsolete("Deprecated in favour of \"NotMergedInsufficientStorageExt\"")]
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_INSUFFICIENT_STORAGE_EXT")]
        SubpassMergeStatusNotMergedInsufficientStorageExt = 9,
        [Obsolete("Deprecated in favour of \"NotMergedDepthStencilCountExt\"")]
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_DEPTH_STENCIL_COUNT_EXT")]
        SubpassMergeStatusNotMergedDepthStencilCountExt = 10,
        [Obsolete("Deprecated in favour of \"NotMergedResolveAttachmentReuseExt\"")]
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_RESOLVE_ATTACHMENT_REUSE_EXT")]
        SubpassMergeStatusNotMergedResolveAttachmentReuseExt = 11,
        [Obsolete("Deprecated in favour of \"NotMergedSingleSubpassExt\"")]
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SINGLE_SUBPASS_EXT")]
        SubpassMergeStatusNotMergedSingleSubpassExt = 12,
        [Obsolete("Deprecated in favour of \"NotMergedUnspecifiedExt\"")]
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_UNSPECIFIED_EXT")]
        SubpassMergeStatusNotMergedUnspecifiedExt = 13,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_MERGED_EXT")]
        MergedExt = 0,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_DISALLOWED_EXT")]
        DisallowedExt = 1,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SIDE_EFFECTS_EXT")]
        NotMergedSideEffectsExt = 2,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SAMPLES_MISMATCH_EXT")]
        NotMergedSamplesMismatchExt = 3,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_VIEWS_MISMATCH_EXT")]
        NotMergedViewsMismatchExt = 4,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_ALIASING_EXT")]
        NotMergedAliasingExt = 5,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_DEPENDENCIES_EXT")]
        NotMergedDependenciesExt = 6,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_INCOMPATIBLE_INPUT_ATTACHMENT_EXT")]
        NotMergedIncompatibleInputAttachmentExt = 7,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_TOO_MANY_ATTACHMENTS_EXT")]
        NotMergedTooManyAttachmentsExt = 8,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_INSUFFICIENT_STORAGE_EXT")]
        NotMergedInsufficientStorageExt = 9,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_DEPTH_STENCIL_COUNT_EXT")]
        NotMergedDepthStencilCountExt = 10,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_RESOLVE_ATTACHMENT_REUSE_EXT")]
        NotMergedResolveAttachmentReuseExt = 11,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SINGLE_SUBPASS_EXT")]
        NotMergedSingleSubpassExt = 12,
        [NativeName("Name", "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_UNSPECIFIED_EXT")]
        NotMergedUnspecifiedExt = 13,
    }
}
