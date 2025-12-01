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
    [NativeName("GL_MAP_READ_BIT_EXT")]
    ReadBitEXT = unchecked((uint)0x0001),

    [NativeName("GL_MAP_WRITE_BIT_EXT")]
    WriteBitEXT = unchecked((uint)0x0002),

    [NativeName("GL_MAP_INVALIDATE_RANGE_BIT_EXT")]
    InvalidateRangeBitEXT = unchecked((uint)0x0004),

    [NativeName("GL_MAP_INVALIDATE_BUFFER_BIT_EXT")]
    InvalidateBufferBitEXT = unchecked((uint)0x0008),

    [NativeName("GL_MAP_FLUSH_EXPLICIT_BIT_EXT")]
    FlushExplicitBitEXT = unchecked((uint)0x0010),

    [NativeName("GL_MAP_UNSYNCHRONIZED_BIT_EXT")]
    UnsynchronizedBitEXT = unchecked((uint)0x0020),

    [NativeName("GL_MAP_READ_BIT")]
    ReadBit = unchecked((uint)0x0001),

    [NativeName("GL_MAP_WRITE_BIT")]
    WriteBit = unchecked((uint)0x0002),

    [NativeName("GL_MAP_INVALIDATE_RANGE_BIT")]
    InvalidateRangeBit = unchecked((uint)0x0004),

    [NativeName("GL_MAP_INVALIDATE_BUFFER_BIT")]
    InvalidateBufferBit = unchecked((uint)0x0008),

    [NativeName("GL_MAP_FLUSH_EXPLICIT_BIT")]
    FlushExplicitBit = unchecked((uint)0x0010),

    [NativeName("GL_MAP_UNSYNCHRONIZED_BIT")]
    UnsynchronizedBit = unchecked((uint)0x0020),

    [NativeName("GL_MAP_PERSISTENT_BIT")]
    PersistentBit = unchecked((uint)0x0040),

    [NativeName("GL_MAP_COHERENT_BIT")]
    CoherentBit = unchecked((uint)0x0080),

    [NativeName("GL_MAP_PERSISTENT_BIT_EXT")]
    PersistentBitEXT = unchecked((uint)0x0040),

    [NativeName("GL_MAP_COHERENT_BIT_EXT")]
    CoherentBitEXT = unchecked((uint)0x0080),
}
