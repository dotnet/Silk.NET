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
    [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_SERIALIZATION_DESC")]
    public unsafe partial struct RaytracingAccelerationStructurePostbuildInfoSerializationDesc
    {
        public RaytracingAccelerationStructurePostbuildInfoSerializationDesc
        (
            ulong? serializedSizeInBytes = null,
            RaytracingAccelerationStructurePostbuildInfoSerializationDescUnion? anonymous = null,
            ulong? numBottomLevelAccelerationStructurePointers = null,
            ulong? numBottomLevelAccelerationStructureHeaderAndPointerListPairs = null
        ) : this()
        {
            if (serializedSizeInBytes is not null)
            {
                SerializedSizeInBytes = serializedSizeInBytes.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (numBottomLevelAccelerationStructurePointers is not null)
            {
                NumBottomLevelAccelerationStructurePointers = numBottomLevelAccelerationStructurePointers.Value;
            }

            if (numBottomLevelAccelerationStructureHeaderAndPointerListPairs is not null)
            {
                NumBottomLevelAccelerationStructureHeaderAndPointerListPairs = numBottomLevelAccelerationStructureHeaderAndPointerListPairs.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "SerializedSizeInBytes")]
        public ulong SerializedSizeInBytes;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12_L15470_C5")]
        [NativeName("Name", "anonymous1")]
        public RaytracingAccelerationStructurePostbuildInfoSerializationDescUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ulong NumBottomLevelAccelerationStructurePointers
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].NumBottomLevelAccelerationStructurePointers;
        }
#else
        public ulong NumBottomLevelAccelerationStructurePointers
        {
            get => Anonymous.NumBottomLevelAccelerationStructurePointers;
            set => Anonymous.NumBottomLevelAccelerationStructurePointers = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ulong NumBottomLevelAccelerationStructureHeaderAndPointerListPairs
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].NumBottomLevelAccelerationStructureHeaderAndPointerListPairs;
        }
#else
        public ulong NumBottomLevelAccelerationStructureHeaderAndPointerListPairs
        {
            get => Anonymous.NumBottomLevelAccelerationStructureHeaderAndPointerListPairs;
            set => Anonymous.NumBottomLevelAccelerationStructureHeaderAndPointerListPairs = value;
        }
#endif

    }
}
