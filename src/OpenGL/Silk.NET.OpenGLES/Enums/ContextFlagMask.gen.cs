// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGLES
{
    public enum ContextFlagMask
    {
        ContextFlagForwardCompatibleBit = 0x1,
        ContextFlagDebugBit = 0x2,
        ContextFlagDebugBitKhr = 0x2,
        ContextFlagRobustAccessBit = 0x4,
        ContextFlagRobustAccessBitArb = 0x4,
        ContextFlagNoErrorBit = 0x8,
        ContextFlagNoErrorBitKhr = 0x8,
        ContextFlagProtectedContentBitExt = 0x10,
    }
}
