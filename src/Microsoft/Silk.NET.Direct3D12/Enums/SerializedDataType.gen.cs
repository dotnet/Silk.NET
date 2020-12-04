// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SERIALIZED_DATA_TYPE")]
    public enum SerializedDataType
    {
        [NativeName("Name", "D3D12_SERIALIZED_DATA_RAYTRACING_ACCELERATION_STRUCTURE")]
        SerializedDataRaytracingAccelerationStructure = 0x0,
    }
}
