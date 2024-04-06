// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum UniformPName
{
    UniformType = 0x8A37,
    UniformSize = 0x8A38,
    UniformNameLength = 0x8A39,
    UniformBlockIndex = 0x8A3A,
    UniformOffset = 0x8A3B,
    UniformArrayStride = 0x8A3C,
    UniformMatrixStride = 0x8A3D,
    UniformIsRowMajor = 0x8A3E,
    UniformAtomicCounterBufferIndex = 0x92DA
}
