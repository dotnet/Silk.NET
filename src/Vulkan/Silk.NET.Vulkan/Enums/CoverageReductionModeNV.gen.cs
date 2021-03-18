// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkCoverageReductionModeNV")]
    public enum CoverageReductionModeNV : int
    {
        [NativeName("Name", "VK_COVERAGE_REDUCTION_MODE_MERGE_NV")]
        CoverageReductionModeMergeNV = 0,
        [NativeName("Name", "VK_COVERAGE_REDUCTION_MODE_TRUNCATE_NV")]
        CoverageReductionModeTruncateNV = 1,
    }
}
