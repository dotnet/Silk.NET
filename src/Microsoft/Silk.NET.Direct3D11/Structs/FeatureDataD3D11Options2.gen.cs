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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_FEATURE_DATA_D3D11_OPTIONS2")]
    public unsafe partial struct FeatureDataD3D11Options2
    {
        public FeatureDataD3D11Options2
        (
            int pSSpecifiedStencilRefSupported = default,
            int typedUAVLoadAdditionalFormats = default,
            int rOVsSupported = default,
            ConservativeRasterizationTier conservativeRasterizationTier = default,
            TiledResourcesTier tiledResourcesTier = default,
            int mapOnDefaultTextures = default,
            int standardSwizzle = default,
            int unifiedMemoryArchitecture = default
        )
        {
            PSSpecifiedStencilRefSupported = pSSpecifiedStencilRefSupported;
            TypedUAVLoadAdditionalFormats = typedUAVLoadAdditionalFormats;
            ROVsSupported = rOVsSupported;
            ConservativeRasterizationTier = conservativeRasterizationTier;
            TiledResourcesTier = tiledResourcesTier;
            MapOnDefaultTextures = mapOnDefaultTextures;
            StandardSwizzle = standardSwizzle;
            UnifiedMemoryArchitecture = unifiedMemoryArchitecture;
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "PSSpecifiedStencilRefSupported")]
        public int PSSpecifiedStencilRefSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "TypedUAVLoadAdditionalFormats")]
        public int TypedUAVLoadAdditionalFormats;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ROVsSupported")]
        public int ROVsSupported;

        [NativeName("Type", "D3D11_CONSERVATIVE_RASTERIZATION_TIER")]
        [NativeName("Type.Name", "D3D11_CONSERVATIVE_RASTERIZATION_TIER")]
        [NativeName("Name", "ConservativeRasterizationTier")]
        public ConservativeRasterizationTier ConservativeRasterizationTier;

        [NativeName("Type", "D3D11_TILED_RESOURCES_TIER")]
        [NativeName("Type.Name", "D3D11_TILED_RESOURCES_TIER")]
        [NativeName("Name", "TiledResourcesTier")]
        public TiledResourcesTier TiledResourcesTier;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "MapOnDefaultTextures")]
        public int MapOnDefaultTextures;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "StandardSwizzle")]
        public int StandardSwizzle;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "UnifiedMemoryArchitecture")]
        public int UnifiedMemoryArchitecture;
    }
}
