// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE")]
    public enum RaytracingAccelerationStructureType
    {
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL")]
        RaytracingAccelerationStructureTypeTopLevel = 0x0,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL")]
        RaytracingAccelerationStructureTypeBottomLevel = 0x1,
    }
}
