// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum StencilOp : uint
{
    Zero = unchecked((uint)0),
    Invert = unchecked((uint)0x150A),
    Keep = unchecked((uint)0x1E00),
    Replace = unchecked((uint)0x1E01),
    Incr = unchecked((uint)0x1E02),
    Decr = unchecked((uint)0x1E03),
    IncrWrap = unchecked((uint)0x8507),
    DecrWrap = unchecked((uint)0x8508),
}
