// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12_L12484_C5")]
    public unsafe partial struct AnonymousRecordD3d12L12484C5
    {
        public AnonymousRecordD3d12L12484C5
        (
            RaytracingGeometryTrianglesDesc triangles = default,
            RaytracingGeometryAabbsDesc aABBs = default
        )
        {
            Triangles = triangles;
            AABBs = aABBs;
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC")]
        [NativeName("Type.Name", "D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC")]
        [NativeName("Name", "Triangles")]
        public RaytracingGeometryTrianglesDesc Triangles;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_RAYTRACING_GEOMETRY_AABBS_DESC")]
        [NativeName("Type.Name", "D3D12_RAYTRACING_GEOMETRY_AABBS_DESC")]
        [NativeName("Name", "AABBs")]
        public RaytracingGeometryAabbsDesc AABBs;
    }
}
