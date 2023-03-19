// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RAYTRACING_GEOMETRY_TYPE")]
    public enum RaytracingGeometryType : int
    {
        [Obsolete("Deprecated in favour of \"Triangles\"")]
        [NativeName("Name", "D3D12_RAYTRACING_GEOMETRY_TYPE_TRIANGLES")]
        RaytracingGeometryTypeTriangles = 0x0,
        [Obsolete("Deprecated in favour of \"ProceduralPrimitiveAabbs\"")]
        [NativeName("Name", "D3D12_RAYTRACING_GEOMETRY_TYPE_PROCEDURAL_PRIMITIVE_AABBS")]
        RaytracingGeometryTypeProceduralPrimitiveAabbs = 0x1,
        [NativeName("Name", "D3D12_RAYTRACING_GEOMETRY_TYPE_TRIANGLES")]
        Triangles = 0x0,
        [NativeName("Name", "D3D12_RAYTRACING_GEOMETRY_TYPE_PROCEDURAL_PRIMITIVE_AABBS")]
        ProceduralPrimitiveAabbs = 0x1,
    }
}
