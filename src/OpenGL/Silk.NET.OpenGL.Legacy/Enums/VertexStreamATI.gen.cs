// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "VertexStreamATI")]
    public enum VertexStreamATI
    {
        [NativeName("Name", "GL_VERTEX_STREAM0_ATI")]
        VertexStream0Ati = 0x876C,
        [NativeName("Name", "GL_VERTEX_STREAM1_ATI")]
        VertexStream1Ati = 0x876D,
        [NativeName("Name", "GL_VERTEX_STREAM2_ATI")]
        VertexStream2Ati = 0x876E,
        [NativeName("Name", "GL_VERTEX_STREAM3_ATI")]
        VertexStream3Ati = 0x876F,
        [NativeName("Name", "GL_VERTEX_STREAM4_ATI")]
        VertexStream4Ati = 0x8770,
        [NativeName("Name", "GL_VERTEX_STREAM5_ATI")]
        VertexStream5Ati = 0x8771,
        [NativeName("Name", "GL_VERTEX_STREAM6_ATI")]
        VertexStream6Ati = 0x8772,
        [NativeName("Name", "GL_VERTEX_STREAM7_ATI")]
        VertexStream7Ati = 0x8773,
    }
}
