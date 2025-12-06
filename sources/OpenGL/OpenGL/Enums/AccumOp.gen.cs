// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("AccumOp")]
public enum AccumOp : uint
{
    [NativeName("GL_ADD")]
    Add = 260,

    [NativeName("GL_ACCUM")]
    Accum = 256,

    [NativeName("GL_LOAD")]
    Load = 257,

    [NativeName("GL_RETURN")]
    Return = 258,

    [NativeName("GL_MULT")]
    Mult = 259,
}
