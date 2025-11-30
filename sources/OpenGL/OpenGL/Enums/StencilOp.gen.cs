// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("StencilOp")]
[Transformed]
public enum StencilOp : uint
{
    [NativeName("GL_ZERO")]
    Zero = unchecked((uint)0),

    [NativeName("GL_INVERT")]
    Invert = unchecked((uint)0x150A),

    [NativeName("GL_KEEP")]
    Keep = unchecked((uint)0x1E00),

    [NativeName("GL_REPLACE")]
    Replace = unchecked((uint)0x1E01),

    [NativeName("GL_INCR")]
    Incr = unchecked((uint)0x1E02),

    [NativeName("GL_DECR")]
    Decr = unchecked((uint)0x1E03),

    [NativeName("GL_INCR_WRAP")]
    IncrWrap = unchecked((uint)0x8507),

    [NativeName("GL_DECR_WRAP")]
    DecrWrap = unchecked((uint)0x8508),
}
