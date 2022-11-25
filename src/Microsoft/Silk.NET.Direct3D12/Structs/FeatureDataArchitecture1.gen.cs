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
    [NativeName("Name", "D3D12_FEATURE_DATA_ARCHITECTURE1")]
    public unsafe partial struct FeatureDataArchitecture1
    {
        public FeatureDataArchitecture1
        (
            uint? nodeIndex = null,
            Silk.NET.Core.Bool32? tileBasedRenderer = null,
            Silk.NET.Core.Bool32? uMA = null,
            Silk.NET.Core.Bool32? cacheCoherentUMA = null,
            Silk.NET.Core.Bool32? isolatedMMU = null
        ) : this()
        {
            if (nodeIndex is not null)
            {
                NodeIndex = nodeIndex.Value;
            }

            if (tileBasedRenderer is not null)
            {
                TileBasedRenderer = tileBasedRenderer.Value;
            }

            if (uMA is not null)
            {
                UMA = uMA.Value;
            }

            if (cacheCoherentUMA is not null)
            {
                CacheCoherentUMA = cacheCoherentUMA.Value;
            }

            if (isolatedMMU is not null)
            {
                IsolatedMMU = isolatedMMU.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "TileBasedRenderer")]
        public Silk.NET.Core.Bool32 TileBasedRenderer;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "UMA")]
        public Silk.NET.Core.Bool32 UMA;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "CacheCoherentUMA")]
        public Silk.NET.Core.Bool32 CacheCoherentUMA;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "IsolatedMMU")]
        public Silk.NET.Core.Bool32 IsolatedMMU;
    }
}
