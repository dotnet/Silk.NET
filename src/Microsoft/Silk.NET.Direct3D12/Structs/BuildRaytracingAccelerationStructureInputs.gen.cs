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
    [NativeName("Name", "D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS")]
    public unsafe partial struct BuildRaytracingAccelerationStructureInputs
    {
        public BuildRaytracingAccelerationStructureInputs
        (
            RaytracingAccelerationStructureType? type = null,
            RaytracingAccelerationStructureBuildFlags? flags = null,
            uint? numDescs = null,
            ElementsLayout? descsLayout = null,
            BuildRaytracingAccelerationStructureInputsUnion? anonymous = null,
            ulong? instanceDescs = null,
            RaytracingGeometryDesc* pGeometryDescs = null,
            RaytracingGeometryDesc** ppGeometryDescs = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (numDescs is not null)
            {
                NumDescs = numDescs.Value;
            }

            if (descsLayout is not null)
            {
                DescsLayout = descsLayout.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

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


        [NativeName("Type", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE")]
        [NativeName("Type.Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE")]
        [NativeName("Name", "Type")]
        public RaytracingAccelerationStructureType Type;

        [NativeName("Type", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAGS")]
        [NativeName("Type.Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAGS")]
        [NativeName("Name", "Flags")]
        public RaytracingAccelerationStructureBuildFlags Flags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumDescs")]
        public uint NumDescs;

        [NativeName("Type", "D3D12_ELEMENTS_LAYOUT")]
        [NativeName("Type.Name", "D3D12_ELEMENTS_LAYOUT")]
        [NativeName("Name", "DescsLayout")]
        public ElementsLayout DescsLayout;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12_L14674_C5")]
        [NativeName("Name", "anonymous1")]
        public BuildRaytracingAccelerationStructureInputsUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ulong InstanceDescs
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].InstanceDescs;
        }
#else
        public ulong InstanceDescs
        {
            get => Anonymous.InstanceDescs;
            set => Anonymous.InstanceDescs = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref RaytracingGeometryDesc* PGeometryDescs
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PGeometryDescs;
        }
#else
        public RaytracingGeometryDesc* PGeometryDescs
        {
            get => Anonymous.PGeometryDescs;
            set => Anonymous.PGeometryDescs = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref RaytracingGeometryDesc** PpGeometryDescs
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PpGeometryDescs;
        }
#else
        public RaytracingGeometryDesc** PpGeometryDescs
        {
            get => Anonymous.PpGeometryDescs;
            set => Anonymous.PpGeometryDescs = value;
        }
#endif

    }
}
