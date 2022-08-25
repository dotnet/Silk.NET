// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrDebugUtilsMessageSeverityFlagsEXT")]
    public enum DebugUtilsMessageSeverityFlagsEXT : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"VerboseBitExt\"")]
        [NativeName("Name", "XR_DEBUG_UTILS_MESSAGE_SEVERITY_VERBOSE_BIT_EXT")]
        DebugUtilsMessageSeverityVerboseBitExt = 1,
        [Obsolete("Deprecated in favour of \"InfoBitExt\"")]
        [NativeName("Name", "XR_DEBUG_UTILS_MESSAGE_SEVERITY_INFO_BIT_EXT")]
        DebugUtilsMessageSeverityInfoBitExt = 16,
        [Obsolete("Deprecated in favour of \"WarningBitExt\"")]
        [NativeName("Name", "XR_DEBUG_UTILS_MESSAGE_SEVERITY_WARNING_BIT_EXT")]
        DebugUtilsMessageSeverityWarningBitExt = 256,
        [Obsolete("Deprecated in favour of \"ErrorBitExt\"")]
        [NativeName("Name", "XR_DEBUG_UTILS_MESSAGE_SEVERITY_ERROR_BIT_EXT")]
        DebugUtilsMessageSeverityErrorBitExt = 4096,
        [NativeName("Name", "XR_DEBUG_UTILS_MESSAGE_SEVERITY_VERBOSE_BIT_EXT")]
        VerboseBitExt = 1,
        [NativeName("Name", "XR_DEBUG_UTILS_MESSAGE_SEVERITY_INFO_BIT_EXT")]
        InfoBitExt = 16,
        [NativeName("Name", "XR_DEBUG_UTILS_MESSAGE_SEVERITY_WARNING_BIT_EXT")]
        WarningBitExt = 256,
        [NativeName("Name", "XR_DEBUG_UTILS_MESSAGE_SEVERITY_ERROR_BIT_EXT")]
        ErrorBitExt = 4096,
    }
}
