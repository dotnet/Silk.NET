// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGLES
{
    public enum MapBufferAccessMask
    {
        MapReadBit = 0x1,
        MapReadBitExt = 0x1,
        MapWriteBit = 0x2,
        MapWriteBitExt = 0x2,
        MapInvalidateRangeBit = 0x4,
        MapInvalidateRangeBitExt = 0x4,
        MapInvalidateBufferBit = 0x8,
        MapInvalidateBufferBitExt = 0x8,
        MapFlushExplicitBit = 0x10,
        MapFlushExplicitBitExt = 0x10,
        MapUnsynchronizedBit = 0x20,
        MapUnsynchronizedBitExt = 0x20,
        MapPersistentBit = 0x40,
        MapPersistentBitExt = 0x40,
        MapCoherentBit = 0x80,
        MapCoherentBitExt = 0x80,
    }
}
