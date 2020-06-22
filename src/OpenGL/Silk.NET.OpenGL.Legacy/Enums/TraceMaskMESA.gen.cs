// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    public enum TraceMaskMESA
    {
        TraceOperationsBitMesa = 0x1,
        TracePrimitivesBitMesa = 0x2,
        TraceArraysBitMesa = 0x4,
        TraceTexturesBitMesa = 0x8,
        TracePixelsBitMesa = 0x10,
        TraceErrorsBitMesa = 0x20,
        TraceAllBitsMesa = 0xFFFF,
    }
}
