// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PrimitiveType : uint
{
    Points = 0x0000,
    Lines = 0x0001,
    LineLoop = 0x0002,
    LineStrip = 0x0003,
    Triangles = 0x0004,
    TriangleStrip = 0x0005,
    TriangleFan = 0x0006,
    Quads = 0x0007,
    LinesAdjacency = 0x000A,
    LineStripAdjacency = 0x000B,
    TrianglesAdjacency = 0x000C,
    TriangleStripAdjacency = 0x000D,
    Patches = 0x000E,
    LinesAdjacencyARB = 0x000A,
    LineStripAdjacencyARB = 0x000B,
    TrianglesAdjacencyARB = 0x000C,
    TriangleStripAdjacencyARB = 0x000D,
    QuadStrip = 0x0008,
    Polygon = 0x0009,
    LinesAdjacencyEXT = 0x000A,
    LineStripAdjacencyEXT = 0x000B,
    TrianglesAdjacencyEXT = 0x000C,
    TriangleStripAdjacencyEXT = 0x000D,
    PatchesEXT = 0x000E,
    QuadsEXT = 0x0007
}
