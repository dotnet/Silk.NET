// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FragmentOp2ATI")]
public enum FragmentOp2ATI : uint
{
    [NativeName("GL_ADD_ATI")]
    Add = 35171,

    [NativeName("GL_MUL_ATI")]
    Mul = 35172,

    [NativeName("GL_SUB_ATI")]
    Sub = 35173,

    [NativeName("GL_DOT3_ATI")]
    Dot3 = 35174,

    [NativeName("GL_DOT4_ATI")]
    Dot4 = 35175,
}
