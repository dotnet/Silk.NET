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
    [NativeName("Name", "D3D12_RAYTRACING_SERIALIZED_BLOCK")]
    public unsafe partial struct RaytracingSerializedBlock
    {
        public RaytracingSerializedBlock
        (
            SerializedBlockType? type = null,
            ulong? numBlockPointersAfterHeader = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (numBlockPointersAfterHeader is not null)
            {
                NumBlockPointersAfterHeader = numBlockPointersAfterHeader.Value;
            }
        }


        [NativeName("Type", "D3D12_RAYTRACING_SERIALIZED_BLOCK_TYPE")]
        [NativeName("Type.Name", "D3D12_RAYTRACING_SERIALIZED_BLOCK_TYPE")]
        [NativeName("Name", "Type")]
        public SerializedBlockType Type;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "NumBlockPointersAfterHeader")]
        public ulong NumBlockPointersAfterHeader;
    }
}
