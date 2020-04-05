// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGL
{
    public enum BufferStorageMask
    {
        DynamicStorageBit = 0x100,
        DynamicStorageBitExt = 0x100,
        ClientStorageBit = 0x200,
        ClientStorageBitExt = 0x200,
        SparseStorageBitArb = 0x400,
        LgpuSeparateStorageBitNvx = 0x800,
        PerGpuStorageBitNV = 0x800,
        ExternalStorageBitNvx = 0x2000,
        MapReadBit = 0x1,
        MapReadBitExt = 0x1,
        MapWriteBit = 0x2,
        MapWriteBitExt = 0x2,
        MapPersistentBit = 0x40,
        MapPersistentBitExt = 0x40,
        MapCoherentBit = 0x80,
        MapCoherentBitExt = 0x80,
    }
}
