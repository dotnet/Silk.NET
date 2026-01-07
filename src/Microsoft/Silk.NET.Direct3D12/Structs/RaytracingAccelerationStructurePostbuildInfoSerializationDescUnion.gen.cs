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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12_L15470_C5")]
    public unsafe partial struct RaytracingAccelerationStructurePostbuildInfoSerializationDescUnion
    {
        public RaytracingAccelerationStructurePostbuildInfoSerializationDescUnion
        (
            ulong? numBottomLevelAccelerationStructurePointers = null,
            ulong? numBottomLevelAccelerationStructureHeaderAndPointerListPairs = null
        ) : this()
        {
            if (numBottomLevelAccelerationStructurePointers is not null)
            {
                NumBottomLevelAccelerationStructurePointers = numBottomLevelAccelerationStructurePointers.Value;
            }

            if (numBottomLevelAccelerationStructureHeaderAndPointerListPairs is not null)
            {
                NumBottomLevelAccelerationStructureHeaderAndPointerListPairs = numBottomLevelAccelerationStructureHeaderAndPointerListPairs.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "NumBottomLevelAccelerationStructurePointers")]
        public ulong NumBottomLevelAccelerationStructurePointers;

        [FieldOffset(0)]
        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "NumBottomLevelAccelerationStructureHeaderAndPointerListPairs")]
        public ulong NumBottomLevelAccelerationStructureHeaderAndPointerListPairs;
    }
}
