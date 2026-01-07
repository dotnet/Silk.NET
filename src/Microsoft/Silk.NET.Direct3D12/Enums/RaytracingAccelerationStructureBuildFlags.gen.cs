// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAGS")]
    public enum RaytracingAccelerationStructureBuildFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_NONE")]
        RaytracingAccelerationStructureBuildFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"AllowUpdate\"")]
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_ALLOW_UPDATE")]
        RaytracingAccelerationStructureBuildFlagAllowUpdate = 0x1,
        [Obsolete("Deprecated in favour of \"AllowCompaction\"")]
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_ALLOW_COMPACTION")]
        RaytracingAccelerationStructureBuildFlagAllowCompaction = 0x2,
        [Obsolete("Deprecated in favour of \"PreferFastTrace\"")]
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_PREFER_FAST_TRACE")]
        RaytracingAccelerationStructureBuildFlagPreferFastTrace = 0x4,
        [Obsolete("Deprecated in favour of \"PreferFastBuild\"")]
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_PREFER_FAST_BUILD")]
        RaytracingAccelerationStructureBuildFlagPreferFastBuild = 0x8,
        [Obsolete("Deprecated in favour of \"MinimizeMemory\"")]
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_MINIMIZE_MEMORY")]
        RaytracingAccelerationStructureBuildFlagMinimizeMemory = 0x10,
        [Obsolete("Deprecated in favour of \"PerformUpdate\"")]
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_PERFORM_UPDATE")]
        RaytracingAccelerationStructureBuildFlagPerformUpdate = 0x20,
        [Obsolete("Deprecated in favour of \"AllowOmmUpdate\"")]
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_ALLOW_OMM_UPDATE")]
        RaytracingAccelerationStructureBuildFlagAllowOmmUpdate = 0x40,
        [Obsolete("Deprecated in favour of \"AllowDisableOmms\"")]
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_ALLOW_DISABLE_OMMS")]
        RaytracingAccelerationStructureBuildFlagAllowDisableOmms = 0x80,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_ALLOW_UPDATE")]
        AllowUpdate = 0x1,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_ALLOW_COMPACTION")]
        AllowCompaction = 0x2,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_PREFER_FAST_TRACE")]
        PreferFastTrace = 0x4,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_PREFER_FAST_BUILD")]
        PreferFastBuild = 0x8,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_MINIMIZE_MEMORY")]
        MinimizeMemory = 0x10,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_PERFORM_UPDATE")]
        PerformUpdate = 0x20,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_ALLOW_OMM_UPDATE")]
        AllowOmmUpdate = 0x40,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_ALLOW_DISABLE_OMMS")]
        AllowDisableOmms = 0x80,
    }
}
