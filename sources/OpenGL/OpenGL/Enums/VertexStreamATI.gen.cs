// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("VertexStreamATI")]
public enum VertexStreamATI : uint
{
    [NativeName("GL_VERTEX_STREAM0_ATI")]
    Stream0 = unchecked((uint)0x876C),

    [NativeName("GL_VERTEX_STREAM1_ATI")]
    Stream1 = unchecked((uint)0x876D),

    [NativeName("GL_VERTEX_STREAM2_ATI")]
    Stream2 = unchecked((uint)0x876E),

    [NativeName("GL_VERTEX_STREAM3_ATI")]
    Stream3 = unchecked((uint)0x876F),

    [NativeName("GL_VERTEX_STREAM4_ATI")]
    Stream4 = unchecked((uint)0x8770),

    [NativeName("GL_VERTEX_STREAM5_ATI")]
    Stream5 = unchecked((uint)0x8771),

    [NativeName("GL_VERTEX_STREAM6_ATI")]
    Stream6 = unchecked((uint)0x8772),

    [NativeName("GL_VERTEX_STREAM7_ATI")]
    Stream7 = unchecked((uint)0x8773),
}
