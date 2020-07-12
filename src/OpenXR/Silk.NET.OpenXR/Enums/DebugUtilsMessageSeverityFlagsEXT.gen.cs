// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags()]
    [NativeName("Name", "XrDebugUtilsMessageSeverityFlagsEXT")]
    public enum DebugUtilsMessageSeverityFlagsEXT
    {
        [NativeName("Name", "XR_DEBUG_UTILS_MESSAGE_SEVERITY_VERBOSE_BIT_EXT")]
        DebugUtilsMessageSeverityVerboseBitExt = 1,
        [NativeName("Name", "XR_DEBUG_UTILS_MESSAGE_SEVERITY_INFO_BIT_EXT")]
        DebugUtilsMessageSeverityInfoBitExt = 16,
        [NativeName("Name", "XR_DEBUG_UTILS_MESSAGE_SEVERITY_WARNING_BIT_EXT")]
        DebugUtilsMessageSeverityWarningBitExt = 256,
        [NativeName("Name", "XR_DEBUG_UTILS_MESSAGE_SEVERITY_ERROR_BIT_EXT")]
        DebugUtilsMessageSeverityErrorBitExt = 4096,
    }
}
