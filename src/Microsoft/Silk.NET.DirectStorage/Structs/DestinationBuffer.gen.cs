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

namespace Silk.NET.DirectStorage
{
    [NativeName("Name", "DSTORAGE_DESTINATION_BUFFER")]
    public unsafe partial struct DestinationBuffer
    {
        public DestinationBuffer
        (
            Silk.NET.Direct3D12.ID3D12Resource* resource = null,
            ulong? offset = null,
            uint? size = null
        ) : this()
        {
            if (resource is not null)
            {
                Resource = resource;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }
        }


        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "Resource")]
        public Silk.NET.Direct3D12.ID3D12Resource* Resource;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Offset")]
        public ulong Offset;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "Size")]
        public uint Size;
    }
}
