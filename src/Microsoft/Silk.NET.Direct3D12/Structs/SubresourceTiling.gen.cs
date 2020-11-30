// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
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
            uint? widthInTiles = null,
            ushort? heightInTiles = null,
            ushort? depthInTiles = null,
            uint? startTileIndexInOverallResource = null
        ) : this()
        {
            if (widthInTiles is not null)
            {
                WidthInTiles = widthInTiles.Value;
            }

            if (heightInTiles is not null)
            {
                HeightInTiles = heightInTiles.Value;
            }

            if (depthInTiles is not null)
            {
                DepthInTiles = depthInTiles.Value;
            }

            if (startTileIndexInOverallResource is not null)
            {
                StartTileIndexInOverallResource = startTileIndexInOverallResource.Value;
            }
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
