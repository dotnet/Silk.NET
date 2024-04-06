// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum StencilOp
{
    ZERO = 0,
    Invert = 0x150A,
    KEEP = 0x1E00,
    Replace = 0x1E01,
    INCR = 0x1E02,
    DECR = 0x1E03,
    IncrWrap = 0x8507,
    DecrWrap = 0x8508
}
