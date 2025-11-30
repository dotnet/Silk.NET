// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("BufferStorageMask")]
[Transformed]
[Flags]
public enum BufferStorageMask : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAP_READ_BIT_EXT")]
    MapReadBitext = unchecked((uint)0x0001),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAP_WRITE_BIT_EXT")]
    MapWriteBitext = unchecked((uint)0x0002),

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

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_SPARSE_STORAGE_BIT_ARB")]
    SparseStorageBitarb = unchecked((uint)0x0400),

    [NameAffix("Suffix", "NVX", 0)]
    [NativeName("GL_LGPU_SEPARATE_STORAGE_BIT_NVX")]
    LgpuSeparateStorageBitnvx = unchecked((uint)0x0800),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PER_GPU_STORAGE_BIT_NV")]
    PerGpuStorageBitnv = unchecked((uint)0x0800),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAP_PERSISTENT_BIT_EXT")]
    MapPersistentBitext = unchecked((uint)0x0040),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAP_COHERENT_BIT_EXT")]
    MapCoherentBitext = unchecked((uint)0x0080),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DYNAMIC_STORAGE_BIT_EXT")]
    DynamicStorageBitext = unchecked((uint)0x0100),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CLIENT_STORAGE_BIT_EXT")]
    ClientStorageBitext = unchecked((uint)0x0200),
}
