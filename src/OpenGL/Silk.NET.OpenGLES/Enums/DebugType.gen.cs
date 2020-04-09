// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGLES
{
    public enum DebugType
    {
        DontCare = 0x1100,
        DebugTypeError = 0x824C,
        DebugTypeDeprecatedBehavior = 0x824D,
        DebugTypeUndefinedBehavior = 0x824E,
        DebugTypePortability = 0x824F,
        DebugTypePerformance = 0x8250,
        DebugTypeOther = 0x8251,
        DebugTypeMarker = 0x8268,
        DebugTypePushGroup = 0x8269,
        DebugTypePopGroup = 0x826A,
    }
}
