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
    [NativeName("Name", "DSTORAGE_DESTINATION_MULTIPLE_SUBRESOURCES_RANGE")]
    public unsafe partial struct DestinationMultipleSubresourcesRange
    {
        public DestinationMultipleSubresourcesRange
        (
            Silk.NET.Direct3D12.ID3D12Resource* resource = null,
            uint? firstSubresource = null,
            uint? numSubresources = null
        ) : this()
        {
            if (resource is not null)
            {
                Resource = resource;
            }

            if (firstSubresource is not null)
            {
                FirstSubresource = firstSubresource.Value;
            }

            if (numSubresources is not null)
            {
                NumSubresources = numSubresources.Value;
            }
        }


        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "Resource")]
        public Silk.NET.Direct3D12.ID3D12Resource* Resource;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FirstSubresource")]
        public uint FirstSubresource;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumSubresources")]
        public uint NumSubresources;
    }
}
