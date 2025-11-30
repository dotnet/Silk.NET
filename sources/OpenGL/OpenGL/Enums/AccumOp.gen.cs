// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("AccumOp")]
[Transformed]
public enum AccumOp : uint
{
    [NativeName("GL_ADD")]
    Add = unchecked((uint)0x0104),

    [NativeName("GL_ACCUM")]
    Accum = unchecked((uint)0x0100),

    [NativeName("GL_LOAD")]
    Load = unchecked((uint)0x0101),

    [NativeName("GL_RETURN")]
    Return = unchecked((uint)0x0102),

    [NativeName("GL_MULT")]
    Mult = unchecked((uint)0x0103),
}
