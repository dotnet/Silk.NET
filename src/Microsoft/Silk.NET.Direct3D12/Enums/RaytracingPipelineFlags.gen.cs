// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_RAYTRACING_PIPELINE_FLAGS")]
    public enum RaytracingPipelineFlags : int
    {
        [NativeName("Name", "D3D12_RAYTRACING_PIPELINE_FLAG_NONE")]
        RaytracingPipelineFlagNone = 0x0,
        [NativeName("Name", "D3D12_RAYTRACING_PIPELINE_FLAG_SKIP_TRIANGLES")]
        RaytracingPipelineFlagSkipTriangles = 0x100,
        [NativeName("Name", "D3D12_RAYTRACING_PIPELINE_FLAG_SKIP_PROCEDURAL_PRIMITIVES")]
        RaytracingPipelineFlagSkipProceduralPrimitives = 0x200,
    }
}
