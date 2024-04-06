// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum MapBufferAccessMask
{
    ReadBit = 0x0001,
    WriteBit = 0x0002,
    InvalidateRangeBit = 0x0004,
    InvalidateBufferBit = 0x0008,
    FlushExplicitBit = 0x0010,
    UnsynchronizedBit = 0x0020,
    PersistentBit = 0x0040,
    CoherentBit = 0x0080,
    ReadBitEXT = 0x0001,
    WriteBitEXT = 0x0002,
    InvalidateRangeBitEXT = 0x0004,
    InvalidateBufferBitEXT = 0x0008,
    FlushExplicitBitEXT = 0x0010,
    UnsynchronizedBitEXT = 0x0020,
    PersistentBitEXT = 0x0040,
    CoherentBitEXT = 0x0080
}
