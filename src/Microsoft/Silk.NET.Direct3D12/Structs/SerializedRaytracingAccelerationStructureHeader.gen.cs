// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
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
            SerializedDataDriverMatchingIdentifier? driverMatchingIdentifier = null,
            ulong? serializedSizeInBytesIncludingHeader = null,
            ulong? deserializedSizeInBytes = null,
            ulong? numBottomLevelAccelerationStructurePointersAfterHeader = null
        ) : this()
        {
            if (driverMatchingIdentifier is not null)
            {
                DriverMatchingIdentifier = driverMatchingIdentifier.Value;
            }

            if (serializedSizeInBytesIncludingHeader is not null)
            {
                SerializedSizeInBytesIncludingHeader = serializedSizeInBytesIncludingHeader.Value;
            }

            if (deserializedSizeInBytes is not null)
            {
                DeserializedSizeInBytes = deserializedSizeInBytes.Value;
            }

            if (numBottomLevelAccelerationStructurePointersAfterHeader is not null)
            {
                NumBottomLevelAccelerationStructurePointersAfterHeader = numBottomLevelAccelerationStructurePointersAfterHeader.Value;
            }
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
