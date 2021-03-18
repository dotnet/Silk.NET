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
    [NativeName("Name", "D3D12_PLACED_SUBRESOURCE_FOOTPRINT")]
    public unsafe partial struct PlacedSubresourceFootprint
    {
        public PlacedSubresourceFootprint
        (
            ulong? offset = null,
            SubresourceFootprint? footprint = null
        ) : this()
        {
            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (footprint is not null)
            {
                Footprint = footprint.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Offset")]
        public ulong Offset;

        [NativeName("Type", "D3D12_SUBRESOURCE_FOOTPRINT")]
        [NativeName("Type.Name", "D3D12_SUBRESOURCE_FOOTPRINT")]
        [NativeName("Name", "Footprint")]
        public SubresourceFootprint Footprint;
    }
}
