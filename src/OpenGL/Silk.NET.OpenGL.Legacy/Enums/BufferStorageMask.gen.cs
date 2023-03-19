// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [Flags]
    [NativeName("Name", "BufferStorageMask")]
    public enum BufferStorageMask : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "GL_DYNAMIC_STORAGE_BIT")]
        DynamicStorageBit = 0x100,
        [NativeName("Name", "GL_DYNAMIC_STORAGE_BIT_EXT")]
        DynamicStorageBitExt = 0x100,
        [NativeName("Name", "GL_CLIENT_STORAGE_BIT")]
        ClientStorageBit = 0x200,
        [NativeName("Name", "GL_CLIENT_STORAGE_BIT_EXT")]
        ClientStorageBitExt = 0x200,
        [NativeName("Name", "GL_SPARSE_STORAGE_BIT_ARB")]
        SparseStorageBitArb = 0x400,
        [NativeName("Name", "GL_LGPU_SEPARATE_STORAGE_BIT_NVX")]
        LgpuSeparateStorageBitNvx = 0x800,
        [NativeName("Name", "GL_PER_GPU_STORAGE_BIT_NV")]
        PerGpuStorageBitNV = 0x800,
        [NativeName("Name", "GL_EXTERNAL_STORAGE_BIT_NVX")]
        ExternalStorageBitNvx = 0x2000,
        [NativeName("Name", "GL_MAP_READ_BIT")]
        MapReadBit = 0x1,
        [NativeName("Name", "GL_MAP_READ_BIT_EXT")]
        MapReadBitExt = 0x1,
        [NativeName("Name", "GL_MAP_WRITE_BIT")]
        MapWriteBit = 0x2,
        [NativeName("Name", "GL_MAP_WRITE_BIT_EXT")]
        MapWriteBitExt = 0x2,
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
