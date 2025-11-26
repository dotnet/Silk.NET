// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
[Flags]
public enum MapBufferAccessMask : uint
{
    ReadBit = unchecked((uint)0x0001),
    WriteBit = unchecked((uint)0x0002),
    InvalidateRangeBit = unchecked((uint)0x0004),
    InvalidateBufferBit = unchecked((uint)0x0008),
    FlushExplicitBit = unchecked((uint)0x0010),
    UnsynchronizedBit = unchecked((uint)0x0020),
    PersistentBit = unchecked((uint)0x0040),
    CoherentBit = unchecked((uint)0x0080),
    PersistentBitEXT = unchecked((uint)0x0040),
    CoherentBitEXT = unchecked((uint)0x0080),
    ReadBitEXT = unchecked((uint)0x0001),
    WriteBitEXT = unchecked((uint)0x0002),
    InvalidateRangeBitEXT = unchecked((uint)0x0004),
    InvalidateBufferBitEXT = unchecked((uint)0x0008),
    FlushExplicitBitEXT = unchecked((uint)0x0010),
    UnsynchronizedBitEXT = unchecked((uint)0x0020),
}
