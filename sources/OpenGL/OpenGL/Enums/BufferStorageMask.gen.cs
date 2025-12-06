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

    [NativeName("GL_MAP_READ_BIT")]
    MapReadBit = 0x1,

    [NativeName("GL_MAP_WRITE_BIT")]
    MapWriteBit = 0x2,

    [NativeName("GL_MAP_PERSISTENT_BIT")]
    MapPersistentBit = 0x40,

    [NativeName("GL_MAP_COHERENT_BIT")]
    MapCoherentBit = 0x80,

    [NativeName("GL_DYNAMIC_STORAGE_BIT")]
    DynamicStorageBit = 0x100,

    [NativeName("GL_CLIENT_STORAGE_BIT")]
    ClientStorageBit = 0x200,

    [NativeName("GL_SPARSE_STORAGE_BIT_ARB")]
    SparseStorageBitARB = 0x400,

    [NativeName("GL_LGPU_SEPARATE_STORAGE_BIT_NVX")]
    LgpuSeparateStorageBitNVX = 0x800,

    [NativeName("GL_PER_GPU_STORAGE_BIT_NV")]
    PerGpuStorageBitNV = 0x800,

    [NativeName("GL_MAP_PERSISTENT_BIT_EXT")]
    MapPersistentBitEXT = 0x40,

    [NativeName("GL_MAP_COHERENT_BIT_EXT")]
    MapCoherentBitEXT = 0x80,

    [NativeName("GL_DYNAMIC_STORAGE_BIT_EXT")]
    DynamicStorageBitEXT = 0x100,

    [NativeName("GL_CLIENT_STORAGE_BIT_EXT")]
    ClientStorageBitEXT = 0x200,

    [NativeName("GL_MAP_READ_BIT_EXT")]
    MapReadBitEXT = 0x1,

    [NativeName("GL_MAP_WRITE_BIT_EXT")]
    MapWriteBitEXT = 0x2,
}
