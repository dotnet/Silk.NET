// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER_POSTAMBLE_TYPE")]
    public enum SerializedRaytracingAccelerationStructureHeaderPostambleType : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER_POSTAMBLE_TYPE_NONE")]
        SerializedRaytracingAccelerationStructureHeaderPostambleTypeNone = 0x0,
        [Obsolete("Deprecated in favour of \"BottomLevelPointers\"")]
        [NativeName("Name", "D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER_POSTAMBLE_TYPE_BOTTOM_LEVEL_POINTERS")]
        SerializedRaytracingAccelerationStructureHeaderPostambleTypeBottomLevelPointers = 0x0,
        [Obsolete("Deprecated in favour of \"Blocks\"")]
        [NativeName("Name", "D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER_POSTAMBLE_TYPE_BLOCKS")]
        SerializedRaytracingAccelerationStructureHeaderPostambleTypeBlocks = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER_POSTAMBLE_TYPE_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER_POSTAMBLE_TYPE_BOTTOM_LEVEL_POINTERS")]
        BottomLevelPointers = 0x0,
        [NativeName("Name", "D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER_POSTAMBLE_TYPE_BLOCKS")]
        Blocks = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
