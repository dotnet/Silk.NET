// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("MapBufferAccessMask")]
[Flags]
public enum MapBufferAccessMask : uint
{
    None = 0x0,

    [NativeName("GL_MAP_READ_BIT")]
    ReadBit = 0x1,

    [NativeName("GL_MAP_WRITE_BIT")]
    WriteBit = 0x2,

    [NativeName("GL_MAP_INVALIDATE_RANGE_BIT")]
    InvalidateRangeBit = 0x4,

    [NativeName("GL_MAP_INVALIDATE_BUFFER_BIT")]
    InvalidateBufferBit = 0x8,

    [NativeName("GL_MAP_FLUSH_EXPLICIT_BIT")]
    FlushExplicitBit = 0x10,

    [NativeName("GL_MAP_UNSYNCHRONIZED_BIT")]
    UnsynchronizedBit = 0x20,

    [NativeName("GL_MAP_PERSISTENT_BIT")]
    PersistentBit = 0x40,

    [NativeName("GL_MAP_COHERENT_BIT")]
    CoherentBit = 0x80,

    [NativeName("GL_MAP_PERSISTENT_BIT_EXT")]
    PersistentBitEXT = 0x40,

    [NativeName("GL_MAP_COHERENT_BIT_EXT")]
    CoherentBitEXT = 0x80,

    [NativeName("GL_MAP_READ_BIT_EXT")]
    ReadBitEXT = 0x1,

    [NativeName("GL_MAP_WRITE_BIT_EXT")]
    WriteBitEXT = 0x2,

    [NativeName("GL_MAP_INVALIDATE_RANGE_BIT_EXT")]
    InvalidateRangeBitEXT = 0x4,

    [NativeName("GL_MAP_INVALIDATE_BUFFER_BIT_EXT")]
    InvalidateBufferBitEXT = 0x8,

    [NativeName("GL_MAP_FLUSH_EXPLICIT_BIT_EXT")]
    FlushExplicitBitEXT = 0x10,

    [NativeName("GL_MAP_UNSYNCHRONIZED_BIT_EXT")]
    UnsynchronizedBitEXT = 0x20,
}
