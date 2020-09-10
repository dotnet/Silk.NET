// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER")]
    public unsafe partial struct SerializedRaytracingAccelerationStructureHeader
    {
        public SerializedRaytracingAccelerationStructureHeader
        (
            SerializedDataDriverMatchingIdentifier driverMatchingIdentifier = default,
            ulong serializedSizeInBytesIncludingHeader = default,
            ulong deserializedSizeInBytes = default,
            ulong numBottomLevelAccelerationStructurePointersAfterHeader = default
        )
        {
            DriverMatchingIdentifier = driverMatchingIdentifier;
            SerializedSizeInBytesIncludingHeader = serializedSizeInBytesIncludingHeader;
            DeserializedSizeInBytes = deserializedSizeInBytes;
            NumBottomLevelAccelerationStructurePointersAfterHeader = numBottomLevelAccelerationStructurePointersAfterHeader;
        }


        [NativeName("Type", "D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER")]
        [NativeName("Type.Name", "D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER")]
        [NativeName("Name", "DriverMatchingIdentifier")]
        public SerializedDataDriverMatchingIdentifier DriverMatchingIdentifier;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "SerializedSizeInBytesIncludingHeader")]
        public ulong SerializedSizeInBytesIncludingHeader;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "DeserializedSizeInBytes")]
        public ulong DeserializedSizeInBytes;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "NumBottomLevelAccelerationStructurePointersAfterHeader")]
        public ulong NumBottomLevelAccelerationStructurePointersAfterHeader;
    }
}
