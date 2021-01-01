// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAGS")]
    public enum RaytracingAccelerationStructureBuildFlags : int
    {
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_NONE")]
        RaytracingAccelerationStructureBuildFlagNone = 0x0,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_ALLOW_UPDATE")]
        RaytracingAccelerationStructureBuildFlagAllowUpdate = 0x1,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_ALLOW_COMPACTION")]
        RaytracingAccelerationStructureBuildFlagAllowCompaction = 0x2,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_PREFER_FAST_TRACE")]
        RaytracingAccelerationStructureBuildFlagPreferFastTrace = 0x4,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_PREFER_FAST_BUILD")]
        RaytracingAccelerationStructureBuildFlagPreferFastBuild = 0x8,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_MINIMIZE_MEMORY")]
        RaytracingAccelerationStructureBuildFlagMinimizeMemory = 0x10,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_PERFORM_UPDATE")]
        RaytracingAccelerationStructureBuildFlagPerformUpdate = 0x20,
    }
}
