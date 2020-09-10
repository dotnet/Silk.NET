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
    [NativeName("Name", "D3D12_TILE_SHAPE")]
    public unsafe partial struct TileShape
    {
        public TileShape
        (
            uint widthInTexels = default,
            uint heightInTexels = default,
            uint depthInTexels = default
        )
        {
            WidthInTexels = widthInTexels;
            HeightInTexels = heightInTexels;
            DepthInTexels = depthInTexels;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "WidthInTexels")]
        public uint WidthInTexels;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "HeightInTexels")]
        public uint HeightInTexels;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DepthInTexels")]
        public uint DepthInTexels;
    }
}
