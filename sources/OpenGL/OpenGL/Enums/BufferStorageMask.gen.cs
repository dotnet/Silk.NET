// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
[Flags]
public enum BufferStorageMask : uint
{
    MapReadBit = unchecked((uint)0x0001),
    MapWriteBit = unchecked((uint)0x0002),
    MapPersistentBit = unchecked((uint)0x0040),
    MapCoherentBit = unchecked((uint)0x0080),
    DynamicStorageBit = unchecked((uint)0x0100),
    ClientStorageBit = unchecked((uint)0x0200),
    SparseStorageBitARB = unchecked((uint)0x0400),
    LgpuSeparateStorageBitNVX = unchecked((uint)0x0800),
    PerGpuStorageBitNV = unchecked((uint)0x0800),
    MapPersistentBitEXT = unchecked((uint)0x0040),
    MapCoherentBitEXT = unchecked((uint)0x0080),
    DynamicStorageBitEXT = unchecked((uint)0x0100),
    ClientStorageBitEXT = unchecked((uint)0x0200),
    MapReadBitEXT = unchecked((uint)0x0001),
    MapWriteBitEXT = unchecked((uint)0x0002),
}
