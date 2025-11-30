// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "ATI", 0)]
[NativeName("FragmentOp1ATI")]
[Transformed]
public enum FragmentOp1Ati : uint
{
    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_MOV_ATI")]
    Movati = unchecked((uint)0x8961),
}
