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
    Stream0 = 34668,

    [NativeName("GL_VERTEX_STREAM1_ATI")]
    Stream1 = 34669,

    [NativeName("GL_VERTEX_STREAM2_ATI")]
    Stream2 = 34670,

    [NativeName("GL_VERTEX_STREAM3_ATI")]
    Stream3 = 34671,

    [NativeName("GL_VERTEX_STREAM4_ATI")]
    Stream4 = 34672,

    [NativeName("GL_VERTEX_STREAM5_ATI")]
    Stream5 = 34673,

    [NativeName("GL_VERTEX_STREAM6_ATI")]
    Stream6 = 34674,

    [NativeName("GL_VERTEX_STREAM7_ATI")]
    Stream7 = 34675,
}
