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
    [NativeName("Name", "D3D12_FEATURE_DATA_D3D12_OPTIONS6")]
    public unsafe partial struct FeatureDataD3D12Options6
    {
        public FeatureDataD3D12Options6
        (
            int additionalShadingRatesSupported = default,
            int perPrimitiveShadingRateSupportedWithViewportIndexing = default,
            VariableShadingRateTier variableShadingRateTier = default,
            uint shadingRateImageTileSize = default,
            int backgroundProcessingSupported = default
        )
        {
            AdditionalShadingRatesSupported = additionalShadingRatesSupported;
            PerPrimitiveShadingRateSupportedWithViewportIndexing = perPrimitiveShadingRateSupportedWithViewportIndexing;
            VariableShadingRateTier = variableShadingRateTier;
            ShadingRateImageTileSize = shadingRateImageTileSize;
            BackgroundProcessingSupported = backgroundProcessingSupported;
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "AdditionalShadingRatesSupported")]
        public int AdditionalShadingRatesSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "PerPrimitiveShadingRateSupportedWithViewportIndexing")]
        public int PerPrimitiveShadingRateSupportedWithViewportIndexing;

        [NativeName("Type", "D3D12_VARIABLE_SHADING_RATE_TIER")]
        [NativeName("Type.Name", "D3D12_VARIABLE_SHADING_RATE_TIER")]
        [NativeName("Name", "VariableShadingRateTier")]
        public VariableShadingRateTier VariableShadingRateTier;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ShadingRateImageTileSize")]
        public uint ShadingRateImageTileSize;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "BackgroundProcessingSupported")]
        public int BackgroundProcessingSupported;
    }
}
