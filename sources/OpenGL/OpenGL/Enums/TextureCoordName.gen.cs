// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureCoordName")]
[Transformed]
public enum TextureCoordName : uint
{
    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TEXTURE_GEN_STR_OES")]
    TextureGenStroes = unchecked((uint)0x8D60),

    [NativeName("GL_S")]
    S = unchecked((uint)0x2000),

    [NativeName("GL")]
    [NameAffix("Suffix", "_T", -1)]
    Gl = unchecked((uint)0x2001),

    [NativeName("GL_R")]
    R = unchecked((uint)0x2002),

    [NativeName("GL_Q")]
    Q = unchecked((uint)0x2003),
}
