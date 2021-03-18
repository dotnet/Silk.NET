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
            ulong? numBottomLevelAccelerationStructurePointers = null
        ) : this()
        {
            if (serializedSizeInBytes is not null)
            {
                SerializedSizeInBytes = serializedSizeInBytes.Value;
            }

            if (numBottomLevelAccelerationStructurePointers is not null)
            {
                NumBottomLevelAccelerationStructurePointers = numBottomLevelAccelerationStructurePointers.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "SerializedSizeInBytes")]
        public ulong SerializedSizeInBytes;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "NumBottomLevelAccelerationStructurePointers")]
        public ulong NumBottomLevelAccelerationStructurePointers;
    }
}
