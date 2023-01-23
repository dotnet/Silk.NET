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
    [NativeName("Name", "DSTORAGE_DESTINATION_TILES")]
    public unsafe partial struct DestinationTiles
    {
        public DestinationTiles
        (
            Silk.NET.Direct3D12.ID3D12Resource* resource = null,
            Silk.NET.Direct3D12.TiledResourceCoordinate? tiledRegionStartCoordinate = null,
            Silk.NET.Direct3D12.TileRegionSize? tileRegionSize = null
        ) : this()
        {
            if (resource is not null)
            {
                Resource = resource;
            }

            if (tiledRegionStartCoordinate is not null)
            {
                TiledRegionStartCoordinate = tiledRegionStartCoordinate.Value;
            }

            if (tileRegionSize is not null)
            {
                TileRegionSize = tileRegionSize.Value;
            }
        }


        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "Resource")]
        public Silk.NET.Direct3D12.ID3D12Resource* Resource;

        [NativeName("Type", "D3D12_TILED_RESOURCE_COORDINATE")]
        [NativeName("Type.Name", "D3D12_TILED_RESOURCE_COORDINATE")]
        [NativeName("Name", "TiledRegionStartCoordinate")]
        public Silk.NET.Direct3D12.TiledResourceCoordinate TiledRegionStartCoordinate;

        [NativeName("Type", "D3D12_TILE_REGION_SIZE")]
        [NativeName("Type.Name", "D3D12_TILE_REGION_SIZE")]
        [NativeName("Name", "TileRegionSize")]
        public Silk.NET.Direct3D12.TileRegionSize TileRegionSize;
    }
}
