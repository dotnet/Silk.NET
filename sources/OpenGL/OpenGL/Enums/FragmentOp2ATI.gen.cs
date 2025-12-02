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
    Add = unchecked((uint)0x8963),

    [NativeName("GL_MUL_ATI")]
    Mul = unchecked((uint)0x8964),

    [NativeName("GL_SUB_ATI")]
    Sub = unchecked((uint)0x8965),

    [NativeName("GL_DOT3_ATI")]
    Dot3 = unchecked((uint)0x8966),

    [NativeName("GL_DOT4_ATI")]
    Dot4 = unchecked((uint)0x8967),
}
