// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum BufferStorageMask
{
    MapReadBit = 0x0001,
    MapWriteBit = 0x0002,
    MapPersistentBit = 0x0040,
    MapCoherentBit = 0x0080,
    DynamicStorageBit = 0x0100,
    ClientStorageBit = 0x0200,
    SparseStorageBitARB = 0x0400,
    LgpuSeparateStorageBitNVX = 0x0800,
    PerGpuStorageBitNV = 0x0800,
    MapReadBitEXT = 0x0001,
    MapWriteBitEXT = 0x0002,
    MapPersistentBitEXT = 0x0040,
    MapCoherentBitEXT = 0x0080,
    DynamicStorageBitEXT = 0x0100,
    ClientStorageBitEXT = 0x0200
}
