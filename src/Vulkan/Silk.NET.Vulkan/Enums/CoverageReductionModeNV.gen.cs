// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkCoverageReductionModeNV")]
    public enum CoverageReductionModeNV : int
    {
        [Obsolete("Deprecated in favour of \"MergeNV\"")]
        [NativeName("Name", "VK_COVERAGE_REDUCTION_MODE_MERGE_NV")]
        CoverageReductionModeMergeNV = 0,
        [Obsolete("Deprecated in favour of \"TruncateNV\"")]
        [NativeName("Name", "VK_COVERAGE_REDUCTION_MODE_TRUNCATE_NV")]
        CoverageReductionModeTruncateNV = 1,
        [NativeName("Name", "VK_COVERAGE_REDUCTION_MODE_MERGE_NV")]
        MergeNV = 0,
        [NativeName("Name", "VK_COVERAGE_REDUCTION_MODE_TRUNCATE_NV")]
        TruncateNV = 1,
    }
}
