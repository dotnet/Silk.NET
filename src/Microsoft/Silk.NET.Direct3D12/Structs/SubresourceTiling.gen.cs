// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SUBRESOURCE_TILING")]
    public unsafe partial struct SubresourceTiling
    {
        public SubresourceTiling
        (
            uint widthInTiles = default,
            ushort heightInTiles = default,
            ushort depthInTiles = default,
            uint startTileIndexInOverallResource = default
        )
        {
            WidthInTiles = widthInTiles;
            HeightInTiles = heightInTiles;
            DepthInTiles = depthInTiles;
            StartTileIndexInOverallResource = startTileIndexInOverallResource;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "WidthInTiles")]
        public uint WidthInTiles;

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "HeightInTiles")]
        public ushort HeightInTiles;

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "DepthInTiles")]
        public ushort DepthInTiles;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StartTileIndexInOverallResource")]
        public uint StartTileIndexInOverallResource;
    }
}
