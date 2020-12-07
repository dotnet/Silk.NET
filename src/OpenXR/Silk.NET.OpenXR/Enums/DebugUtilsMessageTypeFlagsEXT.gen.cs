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
    [NativeName("Name", "XrDebugUtilsMessageTypeFlagsEXT")]
    public enum DebugUtilsMessageTypeFlagsEXT
    {
        [NativeName("Name", "XR_DEBUG_UTILS_MESSAGE_TYPE_GENERAL_BIT_EXT")]
        DebugUtilsMessageTypeGeneralBitExt = 1,
        [NativeName("Name", "XR_DEBUG_UTILS_MESSAGE_TYPE_VALIDATION_BIT_EXT")]
        DebugUtilsMessageTypeValidationBitExt = 2,
        [NativeName("Name", "XR_DEBUG_UTILS_MESSAGE_TYPE_PERFORMANCE_BIT_EXT")]
        DebugUtilsMessageTypePerformanceBitExt = 4,
        [NativeName("Name", "XR_DEBUG_UTILS_MESSAGE_TYPE_CONFORMANCE_BIT_EXT")]
        DebugUtilsMessageTypeConformanceBitExt = 8,
    }
}
