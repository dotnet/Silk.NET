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
    [NativeName("Name", "D3D12_FEATURE_DATA_D3D12_OPTIONS6")]
    public unsafe partial struct FeatureDataD3D12Options6
    {
        public FeatureDataD3D12Options6
        (
            Silk.NET.Core.Bool32? additionalShadingRatesSupported = null,
            Silk.NET.Core.Bool32? perPrimitiveShadingRateSupportedWithViewportIndexing = null,
            VariableShadingRateTier? variableShadingRateTier = null,
            uint? shadingRateImageTileSize = null,
            Silk.NET.Core.Bool32? backgroundProcessingSupported = null
        ) : this()
        {
            if (additionalShadingRatesSupported is not null)
            {
                AdditionalShadingRatesSupported = additionalShadingRatesSupported.Value;
            }

            if (perPrimitiveShadingRateSupportedWithViewportIndexing is not null)
            {
                PerPrimitiveShadingRateSupportedWithViewportIndexing = perPrimitiveShadingRateSupportedWithViewportIndexing.Value;
            }

            if (variableShadingRateTier is not null)
            {
                VariableShadingRateTier = variableShadingRateTier.Value;
            }

            if (shadingRateImageTileSize is not null)
            {
                ShadingRateImageTileSize = shadingRateImageTileSize.Value;
            }

            if (backgroundProcessingSupported is not null)
            {
                BackgroundProcessingSupported = backgroundProcessingSupported.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "AdditionalShadingRatesSupported")]
        public Silk.NET.Core.Bool32 AdditionalShadingRatesSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "PerPrimitiveShadingRateSupportedWithViewportIndexing")]
        public Silk.NET.Core.Bool32 PerPrimitiveShadingRateSupportedWithViewportIndexing;

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
        public Silk.NET.Core.Bool32 BackgroundProcessingSupported;
    }
}
