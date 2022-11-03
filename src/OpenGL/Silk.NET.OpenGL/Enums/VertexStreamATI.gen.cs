// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "VertexStreamATI")]
    public enum VertexStreamATI : int
    {
        [Obsolete("Deprecated in favour of \"Stream0Ati\"")]
        [NativeName("Name", "GL_VERTEX_STREAM0_ATI")]
        VertexStream0Ati = 0x876C,
        [Obsolete("Deprecated in favour of \"Stream1Ati\"")]
        [NativeName("Name", "GL_VERTEX_STREAM1_ATI")]
        VertexStream1Ati = 0x876D,
        [Obsolete("Deprecated in favour of \"Stream2Ati\"")]
        [NativeName("Name", "GL_VERTEX_STREAM2_ATI")]
        VertexStream2Ati = 0x876E,
        [Obsolete("Deprecated in favour of \"Stream3Ati\"")]
        [NativeName("Name", "GL_VERTEX_STREAM3_ATI")]
        VertexStream3Ati = 0x876F,
        [Obsolete("Deprecated in favour of \"Stream4Ati\"")]
        [NativeName("Name", "GL_VERTEX_STREAM4_ATI")]
        VertexStream4Ati = 0x8770,
        [Obsolete("Deprecated in favour of \"Stream5Ati\"")]
        [NativeName("Name", "GL_VERTEX_STREAM5_ATI")]
        VertexStream5Ati = 0x8771,
        [Obsolete("Deprecated in favour of \"Stream6Ati\"")]
        [NativeName("Name", "GL_VERTEX_STREAM6_ATI")]
        VertexStream6Ati = 0x8772,
        [Obsolete("Deprecated in favour of \"Stream7Ati\"")]
        [NativeName("Name", "GL_VERTEX_STREAM7_ATI")]
        VertexStream7Ati = 0x8773,
        [NativeName("Name", "GL_VERTEX_STREAM0_ATI")]
        Stream0Ati = 0x876C,
        [NativeName("Name", "GL_VERTEX_STREAM1_ATI")]
        Stream1Ati = 0x876D,
        [NativeName("Name", "GL_VERTEX_STREAM2_ATI")]
        Stream2Ati = 0x876E,
        [NativeName("Name", "GL_VERTEX_STREAM3_ATI")]
        Stream3Ati = 0x876F,
        [NativeName("Name", "GL_VERTEX_STREAM4_ATI")]
        Stream4Ati = 0x8770,
        [NativeName("Name", "GL_VERTEX_STREAM5_ATI")]
        Stream5Ati = 0x8771,
        [NativeName("Name", "GL_VERTEX_STREAM6_ATI")]
        Stream6Ati = 0x8772,
        [NativeName("Name", "GL_VERTEX_STREAM7_ATI")]
        Stream7Ati = 0x8773,
    }
}
