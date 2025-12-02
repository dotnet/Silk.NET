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
    Points = unchecked((uint)0x0000),

    [NativeName("GL_LINES")]
    Lines = unchecked((uint)0x0001),

    [NativeName("GL_LINE_LOOP")]
    LineLoop = unchecked((uint)0x0002),

    [NativeName("GL_LINE_STRIP")]
    LineStrip = unchecked((uint)0x0003),

    [NativeName("GL_TRIANGLES")]
    Triangles = unchecked((uint)0x0004),

    [NativeName("GL_TRIANGLE_STRIP")]
    TriangleStrip = unchecked((uint)0x0005),

    [NativeName("GL_TRIANGLE_FAN")]
    TriangleFan = unchecked((uint)0x0006),

    [NativeName("GL_QUADS")]
    Quads = unchecked((uint)0x0007),

    [NativeName("GL_QUAD_STRIP")]
    QuadStrip = unchecked((uint)0x0008),

    [NativeName("GL_POLYGON")]
    Polygon = unchecked((uint)0x0009),

    [NativeName("GL_LINES_ADJACENCY")]
    LinesAdjacency = unchecked((uint)0x000A),

    [NativeName("GL_LINE_STRIP_ADJACENCY")]
    LineStripAdjacency = unchecked((uint)0x000B),

    [NativeName("GL_TRIANGLES_ADJACENCY")]
    TrianglesAdjacency = unchecked((uint)0x000C),

    [NativeName("GL_TRIANGLE_STRIP_ADJACENCY")]
    TriangleStripAdjacency = unchecked((uint)0x000D),

    [NativeName("GL_PATCHES")]
    Patches = unchecked((uint)0x000E),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_LINES_ADJACENCY_ARB")]
    LinesAdjacencyARB = unchecked((uint)0x000A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_LINE_STRIP_ADJACENCY_ARB")]
    LineStripAdjacencyARB = unchecked((uint)0x000B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TRIANGLES_ADJACENCY_ARB")]
    TrianglesAdjacencyARB = unchecked((uint)0x000C),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TRIANGLE_STRIP_ADJACENCY_ARB")]
    TriangleStripAdjacencyARB = unchecked((uint)0x000D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LINES_ADJACENCY_EXT")]
    LinesAdjacencyEXT = unchecked((uint)0x000A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LINE_STRIP_ADJACENCY_EXT")]
    LineStripAdjacencyEXT = unchecked((uint)0x000B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TRIANGLES_ADJACENCY_EXT")]
    TrianglesAdjacencyEXT = unchecked((uint)0x000C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TRIANGLE_STRIP_ADJACENCY_EXT")]
    TriangleStripAdjacencyEXT = unchecked((uint)0x000D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PATCHES_EXT")]
    PatchesEXT = unchecked((uint)0x000E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_QUADS_EXT")]
    QuadsEXT = unchecked((uint)0x0007),
}
