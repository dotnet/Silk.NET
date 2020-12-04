// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "MapBufferAccessMask")]
    public enum MapBufferAccessMask
    {
        [NativeName("Name", "GL_MAP_READ_BIT")]
        MapReadBit = 0x1,
        [NativeName("Name", "GL_MAP_READ_BIT_EXT")]
        MapReadBitExt = 0x1,
        [NativeName("Name", "GL_MAP_WRITE_BIT")]
        MapWriteBit = 0x2,
        [NativeName("Name", "GL_MAP_WRITE_BIT_EXT")]
        MapWriteBitExt = 0x2,
        [NativeName("Name", "GL_MAP_INVALIDATE_RANGE_BIT")]
        MapInvalidateRangeBit = 0x4,
        [NativeName("Name", "GL_MAP_INVALIDATE_RANGE_BIT_EXT")]
        MapInvalidateRangeBitExt = 0x4,
        [NativeName("Name", "GL_MAP_INVALIDATE_BUFFER_BIT")]
        MapInvalidateBufferBit = 0x8,
        [NativeName("Name", "GL_MAP_INVALIDATE_BUFFER_BIT_EXT")]
        MapInvalidateBufferBitExt = 0x8,
        [NativeName("Name", "GL_MAP_FLUSH_EXPLICIT_BIT")]
        MapFlushExplicitBit = 0x10,
        [NativeName("Name", "GL_MAP_FLUSH_EXPLICIT_BIT_EXT")]
        MapFlushExplicitBitExt = 0x10,
        [NativeName("Name", "GL_MAP_UNSYNCHRONIZED_BIT")]
        MapUnsynchronizedBit = 0x20,
        [NativeName("Name", "GL_MAP_UNSYNCHRONIZED_BIT_EXT")]
        MapUnsynchronizedBitExt = 0x20,
        [NativeName("Name", "GL_MAP_PERSISTENT_BIT")]
        MapPersistentBit = 0x40,
        [NativeName("Name", "GL_MAP_PERSISTENT_BIT_EXT")]
        MapPersistentBitExt = 0x40,
        [NativeName("Name", "GL_MAP_COHERENT_BIT")]
        MapCoherentBit = 0x80,
        [NativeName("Name", "GL_MAP_COHERENT_BIT_EXT")]
        MapCoherentBitExt = 0x80,
    }
}
