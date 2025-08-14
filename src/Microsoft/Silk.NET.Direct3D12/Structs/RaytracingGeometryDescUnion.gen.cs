// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12_L14661_C5")]
    public unsafe partial struct RaytracingGeometryDescUnion
    {
        public RaytracingGeometryDescUnion
        (
            RaytracingGeometryTrianglesDesc? triangles = null,
            RaytracingGeometryAabbsDesc? aABBs = null
        ) : this()
        {
            if (triangles is not null)
            {
                Triangles = triangles.Value;
            }

            if (aABBs is not null)
            {
                AABBs = aABBs.Value;
            }
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
