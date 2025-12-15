// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SERIALIZED_DATA_TYPE")]
    public enum SerializedDataType : int
    {
        [Obsolete("Deprecated in favour of \"RaytracingAccelerationStructure\"")]
        [NativeName("Name", "D3D12_SERIALIZED_DATA_RAYTRACING_ACCELERATION_STRUCTURE")]
        SerializedDataRaytracingAccelerationStructure = 0x0,
        [Obsolete("Deprecated in favour of \"ApplicationSpecificDriverState\"")]
        [NativeName("Name", "D3D12_SERIALIZED_DATA_APPLICATION_SPECIFIC_DRIVER_STATE")]
        SerializedDataApplicationSpecificDriverState = 0x1,
        [NativeName("Name", "D3D12_SERIALIZED_DATA_RAYTRACING_ACCELERATION_STRUCTURE")]
        RaytracingAccelerationStructure = 0x0,
        [NativeName("Name", "D3D12_SERIALIZED_DATA_APPLICATION_SPECIFIC_DRIVER_STATE")]
        ApplicationSpecificDriverState = 0x1,
    }
}
