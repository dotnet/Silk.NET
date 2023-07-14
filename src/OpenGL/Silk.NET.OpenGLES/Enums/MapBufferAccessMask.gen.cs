// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [Flags]
    [NativeName("Name", "MapBufferAccessMask")]
    public enum MapBufferAccessMask : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ReadBit\"")]
        [NativeName("Name", "GL_MAP_READ_BIT")]
        MapReadBit = 0x1,
        [Obsolete("Deprecated in favour of \"ReadBitExt\"")]
        [NativeName("Name", "GL_MAP_READ_BIT_EXT")]
        MapReadBitExt = 0x1,
        [Obsolete("Deprecated in favour of \"WriteBit\"")]
        [NativeName("Name", "GL_MAP_WRITE_BIT")]
        MapWriteBit = 0x2,
        [Obsolete("Deprecated in favour of \"WriteBitExt\"")]
        [NativeName("Name", "GL_MAP_WRITE_BIT_EXT")]
        MapWriteBitExt = 0x2,
        [Obsolete("Deprecated in favour of \"InvalidateRangeBit\"")]
        [NativeName("Name", "GL_MAP_INVALIDATE_RANGE_BIT")]
        MapInvalidateRangeBit = 0x4,
        [Obsolete("Deprecated in favour of \"InvalidateRangeBitExt\"")]
        [NativeName("Name", "GL_MAP_INVALIDATE_RANGE_BIT_EXT")]
        MapInvalidateRangeBitExt = 0x4,
        [Obsolete("Deprecated in favour of \"InvalidateBufferBit\"")]
        [NativeName("Name", "GL_MAP_INVALIDATE_BUFFER_BIT")]
        MapInvalidateBufferBit = 0x8,
        [Obsolete("Deprecated in favour of \"InvalidateBufferBitExt\"")]
        [NativeName("Name", "GL_MAP_INVALIDATE_BUFFER_BIT_EXT")]
        MapInvalidateBufferBitExt = 0x8,
        [Obsolete("Deprecated in favour of \"FlushExplicitBit\"")]
        [NativeName("Name", "GL_MAP_FLUSH_EXPLICIT_BIT")]
        MapFlushExplicitBit = 0x10,
        [Obsolete("Deprecated in favour of \"FlushExplicitBitExt\"")]
        [NativeName("Name", "GL_MAP_FLUSH_EXPLICIT_BIT_EXT")]
        MapFlushExplicitBitExt = 0x10,
        [Obsolete("Deprecated in favour of \"UnsynchronizedBit\"")]
        [NativeName("Name", "GL_MAP_UNSYNCHRONIZED_BIT")]
        MapUnsynchronizedBit = 0x20,
        [Obsolete("Deprecated in favour of \"UnsynchronizedBitExt\"")]
        [NativeName("Name", "GL_MAP_UNSYNCHRONIZED_BIT_EXT")]
        MapUnsynchronizedBitExt = 0x20,
        [Obsolete("Deprecated in favour of \"PersistentBit\"")]
        [NativeName("Name", "GL_MAP_PERSISTENT_BIT")]
        MapPersistentBit = 0x40,
        [Obsolete("Deprecated in favour of \"PersistentBitExt\"")]
        [NativeName("Name", "GL_MAP_PERSISTENT_BIT_EXT")]
        MapPersistentBitExt = 0x40,
        [Obsolete("Deprecated in favour of \"CoherentBit\"")]
        [NativeName("Name", "GL_MAP_COHERENT_BIT")]
        MapCoherentBit = 0x80,
        [Obsolete("Deprecated in favour of \"CoherentBitExt\"")]
        [NativeName("Name", "GL_MAP_COHERENT_BIT_EXT")]
        MapCoherentBitExt = 0x80,
        [NativeName("Name", "GL_MAP_READ_BIT")]
        ReadBit = 0x1,
        [NativeName("Name", "GL_MAP_READ_BIT_EXT")]
        ReadBitExt = 0x1,
        [NativeName("Name", "GL_MAP_WRITE_BIT")]
        WriteBit = 0x2,
        [NativeName("Name", "GL_MAP_WRITE_BIT_EXT")]
        WriteBitExt = 0x2,
        [NativeName("Name", "GL_MAP_INVALIDATE_RANGE_BIT")]
        InvalidateRangeBit = 0x4,
        [NativeName("Name", "GL_MAP_INVALIDATE_RANGE_BIT_EXT")]
        InvalidateRangeBitExt = 0x4,
        [NativeName("Name", "GL_MAP_INVALIDATE_BUFFER_BIT")]
        InvalidateBufferBit = 0x8,
        [NativeName("Name", "GL_MAP_INVALIDATE_BUFFER_BIT_EXT")]
        InvalidateBufferBitExt = 0x8,
        [NativeName("Name", "GL_MAP_FLUSH_EXPLICIT_BIT")]
        FlushExplicitBit = 0x10,
        [NativeName("Name", "GL_MAP_FLUSH_EXPLICIT_BIT_EXT")]
        FlushExplicitBitExt = 0x10,
        [NativeName("Name", "GL_MAP_UNSYNCHRONIZED_BIT")]
        UnsynchronizedBit = 0x20,
        [NativeName("Name", "GL_MAP_UNSYNCHRONIZED_BIT_EXT")]
        UnsynchronizedBitExt = 0x20,
        [NativeName("Name", "GL_MAP_PERSISTENT_BIT")]
        PersistentBit = 0x40,
        [NativeName("Name", "GL_MAP_PERSISTENT_BIT_EXT")]
        PersistentBitExt = 0x40,
        [NativeName("Name", "GL_MAP_COHERENT_BIT")]
        CoherentBit = 0x80,
        [NativeName("Name", "GL_MAP_COHERENT_BIT_EXT")]
        CoherentBitExt = 0x80,
    }
}
