// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RAYTRACING_GEOMETRY_FLAGS")]
    public enum RaytracingGeometryFlags : int
    {
        [NativeName("Name", "D3D12_RAYTRACING_GEOMETRY_FLAG_NONE")]
        RaytracingGeometryFlagNone = 0x0,
        [NativeName("Name", "D3D12_RAYTRACING_GEOMETRY_FLAG_OPAQUE")]
        RaytracingGeometryFlagOpaque = 0x1,
        [NativeName("Name", "D3D12_RAYTRACING_GEOMETRY_FLAG_NO_DUPLICATE_ANYHIT_INVOCATION")]
        RaytracingGeometryFlagNoDuplicateAnyhitInvocation = 0x2,
    }
}
