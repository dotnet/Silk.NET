// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
