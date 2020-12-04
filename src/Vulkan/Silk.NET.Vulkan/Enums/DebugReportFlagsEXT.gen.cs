// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkDebugReportFlagsEXT")]
    public enum DebugReportFlagsEXT
    {
        [NativeName("Name", "VK_DEBUG_REPORT_INFORMATION_BIT_EXT")]
        DebugReportInformationBitExt = 1,
        [NativeName("Name", "VK_DEBUG_REPORT_WARNING_BIT_EXT")]
        DebugReportWarningBitExt = 2,
        [NativeName("Name", "VK_DEBUG_REPORT_PERFORMANCE_WARNING_BIT_EXT")]
        DebugReportPerformanceWarningBitExt = 4,
        [NativeName("Name", "VK_DEBUG_REPORT_ERROR_BIT_EXT")]
        DebugReportErrorBitExt = 8,
        [NativeName("Name", "VK_DEBUG_REPORT_DEBUG_BIT_EXT")]
        DebugReportDebugBitExt = 16,
    }
}
