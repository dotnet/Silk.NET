// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "ATI", 0)]
[NativeName("VertexStreamATI")]
[Transformed]
public enum VertexStreamATI : uint
{
    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_VERTEX_STREAM0_ATI")]
    Stream0ATI = unchecked((uint)0x876C),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_VERTEX_STREAM1_ATI")]
    Stream1ATI = unchecked((uint)0x876D),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_VERTEX_STREAM2_ATI")]
    Stream2ATI = unchecked((uint)0x876E),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_VERTEX_STREAM3_ATI")]
    Stream3ATI = unchecked((uint)0x876F),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_VERTEX_STREAM4_ATI")]
    Stream4ATI = unchecked((uint)0x8770),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_VERTEX_STREAM5_ATI")]
    Stream5ATI = unchecked((uint)0x8771),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_VERTEX_STREAM6_ATI")]
    Stream6ATI = unchecked((uint)0x8772),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_VERTEX_STREAM7_ATI")]
    Stream7ATI = unchecked((uint)0x8773),
}
