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
    [NativeName("Name", "D3D12_TILE_SHAPE")]
    public unsafe partial struct TileShape
    {
        public TileShape
        (
            uint? widthInTexels = null,
            uint? heightInTexels = null,
            uint? depthInTexels = null
        ) : this()
        {
            if (widthInTexels is not null)
            {
                WidthInTexels = widthInTexels.Value;
            }

            if (heightInTexels is not null)
            {
                HeightInTexels = heightInTexels.Value;
            }

            if (depthInTexels is not null)
            {
                DepthInTexels = depthInTexels.Value;
            }
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
