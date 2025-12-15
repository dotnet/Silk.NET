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
    [NativeName("Name", "D3D12_RAYTRACING_GEOMETRY_AABBS_DESC")]
    public unsafe partial struct RaytracingGeometryAabbsDesc
    {
        public RaytracingGeometryAabbsDesc
        (
            ulong? aABBCount = null,
            GpuVirtualAddressAndStride? aABBs = null
        ) : this()
        {
            if (aABBCount is not null)
            {
                AABBCount = aABBCount.Value;
            }

            if (aABBs is not null)
            {
                AABBs = aABBs.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "AABBCount")]
        public ulong AABBCount;

        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE")]
        [NativeName("Name", "AABBs")]
        public GpuVirtualAddressAndStride AABBs;
    }
}
