// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PrimitiveType : uint
{
    Points = unchecked((uint)0x0000),
    Lines = unchecked((uint)0x0001),
    LineLoop = unchecked((uint)0x0002),
    LineStrip = unchecked((uint)0x0003),
    Triangles = unchecked((uint)0x0004),
    TriangleStrip = unchecked((uint)0x0005),
    TriangleFan = unchecked((uint)0x0006),
    Quads = unchecked((uint)0x0007),
    QuadStrip = unchecked((uint)0x0008),
    Polygon = unchecked((uint)0x0009),
    LinesAdjacency = unchecked((uint)0x000A),
    LineStripAdjacency = unchecked((uint)0x000B),
    TrianglesAdjacency = unchecked((uint)0x000C),
    TriangleStripAdjacency = unchecked((uint)0x000D),
    Patches = unchecked((uint)0x000E),
    LinesAdjacencyARB = unchecked((uint)0x000A),
    LineStripAdjacencyARB = unchecked((uint)0x000B),
    TrianglesAdjacencyARB = unchecked((uint)0x000C),
    TriangleStripAdjacencyARB = unchecked((uint)0x000D),
    LinesAdjacencyEXT = unchecked((uint)0x000A),
    LineStripAdjacencyEXT = unchecked((uint)0x000B),
    TrianglesAdjacencyEXT = unchecked((uint)0x000C),
    TriangleStripAdjacencyEXT = unchecked((uint)0x000D),
    PatchesEXT = unchecked((uint)0x000E),
    QuadsEXT = unchecked((uint)0x0007),
}
