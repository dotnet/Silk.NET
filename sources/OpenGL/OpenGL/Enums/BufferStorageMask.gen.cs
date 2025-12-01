// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("BufferStorageMask")]
[Flags]
public enum BufferStorageMask : uint
{
    None = 0x0,

    [NativeName("GL_MAP_READ_BIT_EXT")]
    MapReadBitEXT = unchecked((uint)0x0001),

    [NativeName("GL_MAP_WRITE_BIT_EXT")]
    MapWriteBitEXT = unchecked((uint)0x0002),

    [NativeName("GL_MAP_READ_BIT")]
    MapReadBit = unchecked((uint)0x0001),

    [NativeName("GL_MAP_WRITE_BIT")]
    MapWriteBit = unchecked((uint)0x0002),

    [NativeName("GL_MAP_PERSISTENT_BIT")]
    MapPersistentBit = unchecked((uint)0x0040),

    [NativeName("GL_MAP_COHERENT_BIT")]
    MapCoherentBit = unchecked((uint)0x0080),

    [NativeName("GL_DYNAMIC_STORAGE_BIT")]
    DynamicStorageBit = unchecked((uint)0x0100),

    [NativeName("GL_CLIENT_STORAGE_BIT")]
    ClientStorageBit = unchecked((uint)0x0200),

    [NativeName("GL_SPARSE_STORAGE_BIT_ARB")]
    SparseStorageBitARB = unchecked((uint)0x0400),

    [NativeName("GL_LGPU_SEPARATE_STORAGE_BIT_NVX")]
    LgpuSeparateStorageBitNVX = unchecked((uint)0x0800),

    [NativeName("GL_PER_GPU_STORAGE_BIT_NV")]
    PerGpuStorageBitNV = unchecked((uint)0x0800),

    [NativeName("GL_MAP_PERSISTENT_BIT_EXT")]
    MapPersistentBitEXT = unchecked((uint)0x0040),

    [NativeName("GL_MAP_COHERENT_BIT_EXT")]
    MapCoherentBitEXT = unchecked((uint)0x0080),

    [NativeName("GL_DYNAMIC_STORAGE_BIT_EXT")]
    DynamicStorageBitEXT = unchecked((uint)0x0100),

    [NativeName("GL_CLIENT_STORAGE_BIT_EXT")]
    ClientStorageBitEXT = unchecked((uint)0x0200),
}
