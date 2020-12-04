// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "__AnonymousRecord_d3d12_L12497_C5")]
    public unsafe partial struct AnonymousRecordD3d12L12497C5
    {
        public AnonymousRecordD3d12L12497C5
        (
            ulong? instanceDescs = null,
            RaytracingGeometryDesc* pGeometryDescs = null,
            RaytracingGeometryDesc** ppGeometryDescs = null
        ) : this()
        {
            if (instanceDescs is not null)
            {
                InstanceDescs = instanceDescs.Value;
            }

            if (pGeometryDescs is not null)
            {
                PGeometryDescs = pGeometryDescs;
            }

            if (ppGeometryDescs is not null)
            {
                PpGeometryDescs = ppGeometryDescs;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "InstanceDescs")]
        public ulong InstanceDescs;

        [FieldOffset(0)]
        [NativeName("Type", "const D3D12_RAYTRACING_GEOMETRY_DESC *")]
        [NativeName("Type.Name", "const D3D12_RAYTRACING_GEOMETRY_DESC *")]
        [NativeName("Name", "pGeometryDescs")]
        public RaytracingGeometryDesc* PGeometryDescs;

        [FieldOffset(0)]
        [NativeName("Type", "const D3D12_RAYTRACING_GEOMETRY_DESC *const *")]
        [NativeName("Type.Name", "const D3D12_RAYTRACING_GEOMETRY_DESC *const *")]
        [NativeName("Name", "ppGeometryDescs")]
        public RaytracingGeometryDesc** PpGeometryDescs;
    }
}
