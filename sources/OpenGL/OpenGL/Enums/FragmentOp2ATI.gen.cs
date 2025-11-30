// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "ATI", 0)]
[NativeName("FragmentOp2ATI")]
[Transformed]
public enum FragmentOp2ATI : uint
{
    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_ADD_ATI")]
    AddATI = unchecked((uint)0x8963),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_MUL_ATI")]
    MulATI = unchecked((uint)0x8964),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_SUB_ATI")]
    SubATI = unchecked((uint)0x8965),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DOT3_ATI")]
    Dot3ATI = unchecked((uint)0x8966),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_DOT4_ATI")]
    Dot4ATI = unchecked((uint)0x8967),
}
