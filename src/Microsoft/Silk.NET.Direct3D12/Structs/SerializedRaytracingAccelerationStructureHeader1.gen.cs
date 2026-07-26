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
    [NativeName("Name", "D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER1")]
    public unsafe partial struct SerializedRaytracingAccelerationStructureHeader1
    {
        public SerializedRaytracingAccelerationStructureHeader1
        (
            SerializedDataDriverMatchingIdentifier? driverMatchingIdentifier = null,
            ulong? serializedSizeInBytesIncludingHeader = null,
            ulong? deserializedSizeInBytes = null,
            SerializedRaytracingAccelerationStructureHeader1Union? anonymous = null,
            SerializedRaytracingAccelerationStructureHeaderPostambleType? headerPostambleType = null,
            uint? numBottomLevelAccelerationStructurePointersAfterHeader = null,
            uint? numBlocks = null
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

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (headerPostambleType is not null)
            {
                HeaderPostambleType = headerPostambleType.Value;
            }

            if (numBottomLevelAccelerationStructurePointersAfterHeader is not null)
            {
                NumBottomLevelAccelerationStructurePointersAfterHeader = numBottomLevelAccelerationStructurePointersAfterHeader.Value;
            }

            if (numBlocks is not null)
            {
                NumBlocks = numBlocks.Value;
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

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12_L15521_C5")]
        [NativeName("Name", "anonymous1")]
        public SerializedRaytracingAccelerationStructureHeader1Union Anonymous;

        [NativeName("Type", "D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER_POSTAMBLE_TYPE")]
        [NativeName("Type.Name", "D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER_POSTAMBLE_TYPE")]
        [NativeName("Name", "HeaderPostambleType")]
        public SerializedRaytracingAccelerationStructureHeaderPostambleType HeaderPostambleType;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint NumBottomLevelAccelerationStructurePointersAfterHeader
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].NumBottomLevelAccelerationStructurePointersAfterHeader;
        }
#else
        public uint NumBottomLevelAccelerationStructurePointersAfterHeader
        {
            get => Anonymous.NumBottomLevelAccelerationStructurePointersAfterHeader;
            set => Anonymous.NumBottomLevelAccelerationStructurePointersAfterHeader = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint NumBlocks
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].NumBlocks;
        }
#else
        public uint NumBlocks
        {
            get => Anonymous.NumBlocks;
            set => Anonymous.NumBlocks = value;
        }
#endif

    }
}
