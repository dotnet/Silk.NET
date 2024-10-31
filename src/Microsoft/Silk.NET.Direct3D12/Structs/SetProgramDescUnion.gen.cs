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
    [NativeName("Name", "__AnonymousRecord_d3d12_L20949_C5")]
    public unsafe partial struct SetProgramDescUnion
    {
        public SetProgramDescUnion
        (
            SetGenericPipelineDesc? genericPipeline = null,
            SetRaytracingPipelineDesc? raytracingPipeline = null,
            SetWorkGraphDesc? workGraph = null
        ) : this()
        {
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


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_SET_GENERIC_PIPELINE_DESC")]
        [NativeName("Type.Name", "D3D12_SET_GENERIC_PIPELINE_DESC")]
        [NativeName("Name", "GenericPipeline")]
        public SetGenericPipelineDesc GenericPipeline;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_SET_RAYTRACING_PIPELINE_DESC")]
        [NativeName("Type.Name", "D3D12_SET_RAYTRACING_PIPELINE_DESC")]
        [NativeName("Name", "RaytracingPipeline")]
        public SetRaytracingPipelineDesc RaytracingPipeline;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_SET_WORK_GRAPH_DESC")]
        [NativeName("Type.Name", "D3D12_SET_WORK_GRAPH_DESC")]
        [NativeName("Name", "WorkGraph")]
        public SetWorkGraphDesc WorkGraph;
    }
}
