// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkDebugReportFlagsEXT")]
    public enum DebugReportFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"InformationBitExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_INFORMATION_BIT_EXT")]
        DebugReportInformationBitExt = 1,
        [Obsolete("Deprecated in favour of \"WarningBitExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_WARNING_BIT_EXT")]
        DebugReportWarningBitExt = 2,
        [Obsolete("Deprecated in favour of \"PerformanceWarningBitExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_PERFORMANCE_WARNING_BIT_EXT")]
        DebugReportPerformanceWarningBitExt = 4,
        [Obsolete("Deprecated in favour of \"ErrorBitExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_ERROR_BIT_EXT")]
        DebugReportErrorBitExt = 8,
        [Obsolete("Deprecated in favour of \"DebugBitExt\"")]
        [NativeName("Name", "VK_DEBUG_REPORT_DEBUG_BIT_EXT")]
        DebugReportDebugBitExt = 16,
        [NativeName("Name", "VK_DEBUG_REPORT_INFORMATION_BIT_EXT")]
        InformationBitExt = 1,
        [NativeName("Name", "VK_DEBUG_REPORT_WARNING_BIT_EXT")]
        WarningBitExt = 2,
        [NativeName("Name", "VK_DEBUG_REPORT_PERFORMANCE_WARNING_BIT_EXT")]
        PerformanceWarningBitExt = 4,
        [NativeName("Name", "VK_DEBUG_REPORT_ERROR_BIT_EXT")]
        ErrorBitExt = 8,
        [NativeName("Name", "VK_DEBUG_REPORT_DEBUG_BIT_EXT")]
        DebugBitExt = 16,
    }
}
