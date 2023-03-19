// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_TYPE")]
    public enum RaytracingAccelerationStructurePostbuildInfoType : int
    {
        [Obsolete("Deprecated in favour of \"CompactedSize\"")]
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_COMPACTED_SIZE")]
        RaytracingAccelerationStructurePostbuildInfoCompactedSize = 0x0,
        [Obsolete("Deprecated in favour of \"ToolsVisualization\"")]
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_TOOLS_VISUALIZATION")]
        RaytracingAccelerationStructurePostbuildInfoToolsVisualization = 0x1,
        [Obsolete("Deprecated in favour of \"Serialization\"")]
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_SERIALIZATION")]
        RaytracingAccelerationStructurePostbuildInfoSerialization = 0x2,
        [Obsolete("Deprecated in favour of \"CurrentSize\"")]
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_CURRENT_SIZE")]
        RaytracingAccelerationStructurePostbuildInfoCurrentSize = 0x3,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_COMPACTED_SIZE")]
        CompactedSize = 0x0,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_TOOLS_VISUALIZATION")]
        ToolsVisualization = 0x1,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_SERIALIZATION")]
        Serialization = 0x2,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_CURRENT_SIZE")]
        CurrentSize = 0x3,
    }
}
