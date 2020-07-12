// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags()]
    public enum DebugUtilsMessageTypeFlagsEXT
    {
        DebugUtilsMessageTypeGeneralBitExt = 1,
        DebugUtilsMessageTypeValidationBitExt = 2,
        DebugUtilsMessageTypePerformanceBitExt = 4,
        DebugUtilsMessageTypeConformanceBitExt = 8,
    }
}
