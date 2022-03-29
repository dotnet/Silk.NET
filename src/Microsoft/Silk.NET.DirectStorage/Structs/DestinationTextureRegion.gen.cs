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
    [NativeName("Name", "DSTORAGE_DESTINATION_TEXTURE_REGION")]
    public unsafe partial struct DestinationTextureRegion
    {
        public DestinationTextureRegion
        (
            Silk.NET.Direct3D12.ID3D12Resource* resource = null,
            uint? subresourceIndex = null,
            Silk.NET.Direct3D12.Box? region = null
        ) : this()
        {
            if (resource is not null)
            {
                Resource = resource;
            }

            if (subresourceIndex is not null)
            {
                SubresourceIndex = subresourceIndex.Value;
            }

            if (region is not null)
            {
                Region = region.Value;
            }
        }


        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "Resource")]
        public Silk.NET.Direct3D12.ID3D12Resource* Resource;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SubresourceIndex")]
        public uint SubresourceIndex;

        [NativeName("Type", "D3D12_BOX")]
        [NativeName("Type.Name", "D3D12_BOX")]
        [NativeName("Name", "Region")]
        public Silk.NET.Direct3D12.Box Region;
    }
}
