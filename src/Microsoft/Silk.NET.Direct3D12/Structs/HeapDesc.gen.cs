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
    [NativeName("Name", "D3D12_HEAP_DESC")]
    public unsafe partial struct HeapDesc
    {
        public HeapDesc
        (
            ulong? sizeInBytes = null,
            HeapProperties? properties = null,
            ulong? alignment = null,
            HeapFlags? flags = null
        ) : this()
        {
            if (sizeInBytes is not null)
            {
                SizeInBytes = sizeInBytes.Value;
            }

            if (properties is not null)
            {
                Properties = properties.Value;
            }

            if (alignment is not null)
            {
                Alignment = alignment.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "SizeInBytes")]
        public ulong SizeInBytes;

        [NativeName("Type", "D3D12_HEAP_PROPERTIES")]
        [NativeName("Type.Name", "D3D12_HEAP_PROPERTIES")]
        [NativeName("Name", "Properties")]
        public HeapProperties Properties;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Alignment")]
        public ulong Alignment;

        [NativeName("Type", "D3D12_HEAP_FLAGS")]
        [NativeName("Type.Name", "D3D12_HEAP_FLAGS")]
        [NativeName("Name", "Flags")]
        public HeapFlags Flags;
    }
}
