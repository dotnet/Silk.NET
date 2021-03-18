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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_FEATURE_DATA_D3D11_OPTIONS1")]
    public unsafe partial struct FeatureDataD3D11Options1
    {
        public FeatureDataD3D11Options1
        (
            TiledResourcesTier? tiledResourcesTier = null,
            int? minMaxFiltering = null,
            int? clearViewAlsoSupportsDepthOnlyFormats = null,
            int? mapOnDefaultBuffers = null
        ) : this()
        {
            if (tiledResourcesTier is not null)
            {
                TiledResourcesTier = tiledResourcesTier.Value;
            }

            if (minMaxFiltering is not null)
            {
                MinMaxFiltering = minMaxFiltering.Value;
            }

            if (clearViewAlsoSupportsDepthOnlyFormats is not null)
            {
                ClearViewAlsoSupportsDepthOnlyFormats = clearViewAlsoSupportsDepthOnlyFormats.Value;
            }

            if (mapOnDefaultBuffers is not null)
            {
                MapOnDefaultBuffers = mapOnDefaultBuffers.Value;
            }
        }


        [NativeName("Type", "D3D11_TILED_RESOURCES_TIER")]
        [NativeName("Type.Name", "D3D11_TILED_RESOURCES_TIER")]
        [NativeName("Name", "TiledResourcesTier")]
        public TiledResourcesTier TiledResourcesTier;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "MinMaxFiltering")]
        public int MinMaxFiltering;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ClearViewAlsoSupportsDepthOnlyFormats")]
        public int ClearViewAlsoSupportsDepthOnlyFormats;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "MapOnDefaultBuffers")]
        public int MapOnDefaultBuffers;
    }
}
