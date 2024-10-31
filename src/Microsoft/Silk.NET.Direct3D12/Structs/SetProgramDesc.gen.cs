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
    [NativeName("Name", "D3D12_SET_PROGRAM_DESC")]
    public unsafe partial struct SetProgramDesc
    {
        public SetProgramDesc
        (
            ProgramType? type = null,
            SetProgramDescUnion? anonymous = null,
            SetGenericPipelineDesc? genericPipeline = null,
            SetRaytracingPipelineDesc? raytracingPipeline = null,
            SetWorkGraphDesc? workGraph = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (genericPipeline is not null)
            {
                GenericPipeline = genericPipeline.Value;
            }

            if (raytracingPipeline is not null)
            {
                RaytracingPipeline = raytracingPipeline.Value;
            }

            if (workGraph is not null)
            {
                WorkGraph = workGraph.Value;
            }
        }


        [NativeName("Type", "D3D12_PROGRAM_TYPE")]
        [NativeName("Type.Name", "D3D12_PROGRAM_TYPE")]
        [NativeName("Name", "Type")]
        public ProgramType Type;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12_L20949_C5")]
        [NativeName("Name", "anonymous1")]
        public SetProgramDescUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref SetGenericPipelineDesc GenericPipeline
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].GenericPipeline;
        }
#else
        public SetGenericPipelineDesc GenericPipeline
        {
            get => Anonymous.GenericPipeline;
            set => Anonymous.GenericPipeline = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref SetRaytracingPipelineDesc RaytracingPipeline
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].RaytracingPipeline;
        }
#else
        public SetRaytracingPipelineDesc RaytracingPipeline
        {
            get => Anonymous.RaytracingPipeline;
            set => Anonymous.RaytracingPipeline = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref SetWorkGraphDesc WorkGraph
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].WorkGraph;
        }
#else
        public SetWorkGraphDesc WorkGraph
        {
            get => Anonymous.WorkGraph;
            set => Anonymous.WorkGraph = value;
        }
#endif

    }
}
