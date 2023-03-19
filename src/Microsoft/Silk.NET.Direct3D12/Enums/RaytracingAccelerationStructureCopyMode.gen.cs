// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE")]
    public enum RaytracingAccelerationStructureCopyMode : int
    {
        [Obsolete("Deprecated in favour of \"Clone\"")]
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_CLONE")]
        RaytracingAccelerationStructureCopyModeClone = 0x0,
        [Obsolete("Deprecated in favour of \"Compact\"")]
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_COMPACT")]
        RaytracingAccelerationStructureCopyModeCompact = 0x1,
        [Obsolete("Deprecated in favour of \"VisualizationDecodeForTools\"")]
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_VISUALIZATION_DECODE_FOR_TOOLS")]
        RaytracingAccelerationStructureCopyModeVisualizationDecodeForTools = 0x2,
        [Obsolete("Deprecated in favour of \"Serialize\"")]
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_SERIALIZE")]
        RaytracingAccelerationStructureCopyModeSerialize = 0x3,
        [Obsolete("Deprecated in favour of \"Deserialize\"")]
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_DESERIALIZE")]
        RaytracingAccelerationStructureCopyModeDeserialize = 0x4,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_CLONE")]
        Clone = 0x0,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_COMPACT")]
        Compact = 0x1,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_VISUALIZATION_DECODE_FOR_TOOLS")]
        VisualizationDecodeForTools = 0x2,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_SERIALIZE")]
        Serialize = 0x3,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_DESERIALIZE")]
        Deserialize = 0x4,
    }
}
