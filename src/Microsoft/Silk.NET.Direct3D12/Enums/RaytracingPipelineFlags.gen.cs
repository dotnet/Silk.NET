// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
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
