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
    [NativeName("Name", "D3D12_RESOURCE_ALLOCATION_INFO1")]
    public unsafe partial struct ResourceAllocationInfo1
    {
        public ResourceAllocationInfo1
        (
            ulong? offset = null,
            ulong? alignment = null,
            ulong? sizeInBytes = null
        ) : this()
        {
            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (alignment is not null)
            {
                Alignment = alignment.Value;
            }

            if (sizeInBytes is not null)
            {
                SizeInBytes = sizeInBytes.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Offset")]
        public ulong Offset;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Alignment")]
        public ulong Alignment;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "SizeInBytes")]
        public ulong SizeInBytes;
    }
}
