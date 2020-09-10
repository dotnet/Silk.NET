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
    [NativeName("Name", "D3D12_FEATURE_DATA_ARCHITECTURE")]
    public unsafe partial struct FeatureDataArchitecture
    {
        public FeatureDataArchitecture
        (
            uint nodeIndex = default,
            int tileBasedRenderer = default,
            int uMA = default,
            int cacheCoherentUMA = default
        )
        {
            NodeIndex = nodeIndex;
            TileBasedRenderer = tileBasedRenderer;
            UMA = uMA;
            CacheCoherentUMA = cacheCoherentUMA;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "TileBasedRenderer")]
        public int TileBasedRenderer;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "UMA")]
        public int UMA;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "CacheCoherentUMA")]
        public int CacheCoherentUMA;
    }
}
