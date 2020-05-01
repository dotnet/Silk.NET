// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    public enum InterleavedArrayFormat
    {
        V2f = 0x2A20,
        V3f = 0x2A21,
        C4UBV2f = 0x2A22,
        C4UBV3f = 0x2A23,
        C3fV3f = 0x2A24,
        N3fV3f = 0x2A25,
        C4fN3fV3f = 0x2A26,
        T2fV3f = 0x2A27,
        T4fV4f = 0x2A28,
        T2fC4UBV3f = 0x2A29,
        T2fC3fV3f = 0x2A2A,
        T2fN3fV3f = 0x2A2B,
        T2fC4fN3fV3f = 0x2A2C,
        T4fC4fN3fV4f = 0x2A2D,
    }
}
