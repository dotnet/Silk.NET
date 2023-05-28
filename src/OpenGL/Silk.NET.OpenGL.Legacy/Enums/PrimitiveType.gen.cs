// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "PrimitiveType")]
    public enum PrimitiveType : int
    {
        [NativeName("Name", "GL_POINTS")]
        Points = 0x0,
        [NativeName("Name", "GL_LINES")]
        Lines = 0x1,
        [NativeName("Name", "GL_LINE_LOOP")]
        LineLoop = 0x2,
        [NativeName("Name", "GL_LINE_STRIP")]
        LineStrip = 0x3,
        [NativeName("Name", "GL_TRIANGLES")]
        Triangles = 0x4,
        [NativeName("Name", "GL_TRIANGLE_STRIP")]
        TriangleStrip = 0x5,
        [NativeName("Name", "GL_TRIANGLE_FAN")]
        TriangleFan = 0x6,
        [NativeName("Name", "GL_QUADS")]
        Quads = 0x7,
        [NativeName("Name", "GL_QUADS_EXT")]
        QuadsExt = 0x7,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_QUAD_STRIP")]
        QuadStrip = 0x8,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_POLYGON")]
        Polygon = 0x9,
        [NativeName("Name", "GL_LINES_ADJACENCY")]
        LinesAdjacency = 0xA,
        [NativeName("Name", "GL_LINES_ADJACENCY_ARB")]
        LinesAdjacencyArb = 0xA,
        [NativeName("Name", "GL_LINES_ADJACENCY_EXT")]
        LinesAdjacencyExt = 0xA,
        [NativeName("Name", "GL_LINE_STRIP_ADJACENCY")]
        LineStripAdjacency = 0xB,
        [NativeName("Name", "GL_LINE_STRIP_ADJACENCY_ARB")]
        LineStripAdjacencyArb = 0xB,
        [NativeName("Name", "GL_LINE_STRIP_ADJACENCY_EXT")]
        LineStripAdjacencyExt = 0xB,
        [NativeName("Name", "GL_TRIANGLES_ADJACENCY")]
        TrianglesAdjacency = 0xC,
        [NativeName("Name", "GL_TRIANGLES_ADJACENCY_ARB")]
        TrianglesAdjacencyArb = 0xC,
        [NativeName("Name", "GL_TRIANGLES_ADJACENCY_EXT")]
        TrianglesAdjacencyExt = 0xC,
        [NativeName("Name", "GL_TRIANGLE_STRIP_ADJACENCY")]
        TriangleStripAdjacency = 0xD,
        [NativeName("Name", "GL_TRIANGLE_STRIP_ADJACENCY_ARB")]
        TriangleStripAdjacencyArb = 0xD,
        [NativeName("Name", "GL_TRIANGLE_STRIP_ADJACENCY_EXT")]
        TriangleStripAdjacencyExt = 0xD,
        [NativeName("Name", "GL_PATCHES")]
        Patches = 0xE,
        [NativeName("Name", "GL_PATCHES_EXT")]
        PatchesExt = 0xE,
    }
}
