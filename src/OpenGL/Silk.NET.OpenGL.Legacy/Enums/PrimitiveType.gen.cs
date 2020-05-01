// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    public enum PrimitiveType
    {
        Points = 0x0,
        Lines = 0x1,
        LineLoop = 0x2,
        LineStrip = 0x3,
        Triangles = 0x4,
        TriangleStrip = 0x5,
        TriangleFan = 0x6,
        Quads = 0x7,
        QuadsExt = 0x7,
        QuadStrip = 0x8,
        Polygon = 0x9,
        LinesAdjacency = 0xA,
        LinesAdjacencyArb = 0xA,
        LinesAdjacencyExt = 0xA,
        LineStripAdjacency = 0xB,
        LineStripAdjacencyArb = 0xB,
        LineStripAdjacencyExt = 0xB,
        TrianglesAdjacency = 0xC,
        TrianglesAdjacencyArb = 0xC,
        TrianglesAdjacencyExt = 0xC,
        TriangleStripAdjacency = 0xD,
        TriangleStripAdjacencyArb = 0xD,
        TriangleStripAdjacencyExt = 0xD,
        Patches = 0xE,
        PatchesExt = 0xE,
    }
}
