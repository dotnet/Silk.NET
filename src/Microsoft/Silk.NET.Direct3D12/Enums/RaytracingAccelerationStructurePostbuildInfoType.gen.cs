// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_TYPE")]
    public enum RaytracingAccelerationStructurePostbuildInfoType
    {
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_COMPACTED_SIZE")]
        RaytracingAccelerationStructurePostbuildInfoCompactedSize = 0x0,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_TOOLS_VISUALIZATION")]
        RaytracingAccelerationStructurePostbuildInfoToolsVisualization = 0x1,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_SERIALIZATION")]
        RaytracingAccelerationStructurePostbuildInfoSerialization = 0x2,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_CURRENT_SIZE")]
        RaytracingAccelerationStructurePostbuildInfoCurrentSize = 0x3,
    }
}
