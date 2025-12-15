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
    [NativeName("Name", "D3D12_RAYTRACING_GEOMETRY_OMM_TRIANGLES_DESC")]
    public unsafe partial struct RaytracingGeometryOmmTrianglesDesc
    {
        public RaytracingGeometryOmmTrianglesDesc
        (
            RaytracingGeometryTrianglesDesc* pTriangles = null,
            RaytracingGeometryOmmLinkageDesc* pOmmLinkage = null
        ) : this()
        {
            if (pTriangles is not null)
            {
                PTriangles = pTriangles;
            }

            if (pOmmLinkage is not null)
            {
                POmmLinkage = pOmmLinkage;
            }
        }


        [NativeName("Type", "const D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC *")]
        [NativeName("Type.Name", "const D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC *")]
        [NativeName("Name", "pTriangles")]
        public RaytracingGeometryTrianglesDesc* PTriangles;

        [NativeName("Type", "const D3D12_RAYTRACING_GEOMETRY_OMM_LINKAGE_DESC *")]
        [NativeName("Type.Name", "const D3D12_RAYTRACING_GEOMETRY_OMM_LINKAGE_DESC *")]
        [NativeName("Name", "pOmmLinkage")]
        public RaytracingGeometryOmmLinkageDesc* POmmLinkage;
    }
}
