// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "ATI", 0)]
[NativeName("FragmentOp2ATI")]
public enum FragmentOp2ATI : uint
{
    [NameAffix("Suffix", "ATI", -1)]
    [NativeName("GL_ADD_ATI")]
    Add = unchecked((uint)0x8963),

    [NameAffix("Suffix", "ATI", -1)]
    [NativeName("GL_MUL_ATI")]
    Mul = unchecked((uint)0x8964),

    [NameAffix("Suffix", "ATI", -1)]
    [NativeName("GL_SUB_ATI")]
    Sub = unchecked((uint)0x8965),

    [NameAffix("Suffix", "ATI", -1)]
    [NativeName("GL_DOT3_ATI")]
    Dot3 = unchecked((uint)0x8966),

    [NameAffix("Suffix", "ATI", -1)]
    [NativeName("GL_DOT4_ATI")]
    Dot4 = unchecked((uint)0x8967),
}
