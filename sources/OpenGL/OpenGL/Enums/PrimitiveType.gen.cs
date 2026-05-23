// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PrimitiveType")]
public enum PrimitiveType : uint
{
    [NativeName("GL_POINTS")]
    Points = 0,

    [NativeName("GL_LINES")]
    Lines = 1,

    [NativeName("GL_LINE_LOOP")]
    LineLoop = 2,

    [NativeName("GL_LINE_STRIP")]
    LineStrip = 3,

    [NativeName("GL_TRIANGLES")]
    Triangles = 4,

    [NativeName("GL_TRIANGLE_STRIP")]
    TriangleStrip = 5,

    [NativeName("GL_TRIANGLE_FAN")]
    TriangleFan = 6,

    [NativeName("GL_QUADS")]
    Quads = 7,

    [NativeName("GL_QUAD_STRIP")]
    QuadStrip = 8,

    [NativeName("GL_POLYGON")]
    Polygon = 9,

    [NativeName("GL_LINES_ADJACENCY")]
    LinesAdjacency = 10,

    [NativeName("GL_LINE_STRIP_ADJACENCY")]
    LineStripAdjacency = 11,

    [NativeName("GL_TRIANGLES_ADJACENCY")]
    TrianglesAdjacency = 12,

    [NativeName("GL_TRIANGLE_STRIP_ADJACENCY")]
    TriangleStripAdjacency = 13,

    [NativeName("GL_PATCHES")]
    Patches = 14,

    [NativeName("GL_LINES_ADJACENCY_ARB")]
    LinesAdjacencyARB = 10,

    [NativeName("GL_LINE_STRIP_ADJACENCY_ARB")]
    LineStripAdjacencyARB = 11,

    [NativeName("GL_TRIANGLES_ADJACENCY_ARB")]
    TrianglesAdjacencyARB = 12,

    [NativeName("GL_TRIANGLE_STRIP_ADJACENCY_ARB")]
    TriangleStripAdjacencyARB = 13,

    [NativeName("GL_LINES_ADJACENCY_EXT")]
    LinesAdjacencyEXT = 10,

    [NativeName("GL_LINE_STRIP_ADJACENCY_EXT")]
    LineStripAdjacencyEXT = 11,

    [NativeName("GL_TRIANGLES_ADJACENCY_EXT")]
    TrianglesAdjacencyEXT = 12,

    [NativeName("GL_TRIANGLE_STRIP_ADJACENCY_EXT")]
    TriangleStripAdjacencyEXT = 13,

    [NativeName("GL_PATCHES_EXT")]
    PatchesEXT = 14,

    [NativeName("GL_QUADS_EXT")]
    QuadsEXT = 7,
}
