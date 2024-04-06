// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum UniformPName
{
    Type = 0x8A37,
    Size = 0x8A38,
    NameLength = 0x8A39,
    BlockIndex = 0x8A3A,
    Offset = 0x8A3B,
    ArrayStride = 0x8A3C,
    MatrixStride = 0x8A3D,
    IsRowMajor = 0x8A3E,
    AtomicCounterBufferIndex = 0x92DA
}
