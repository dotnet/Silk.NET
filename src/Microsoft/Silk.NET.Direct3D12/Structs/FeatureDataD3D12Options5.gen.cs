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
    [NativeName("Name", "D3D12_FEATURE_DATA_D3D12_OPTIONS5")]
    public unsafe partial struct FeatureDataD3D12Options5
    {
        public FeatureDataD3D12Options5
        (
            Silk.NET.Core.Bool32? sRVOnlyTiledResourceTier3 = null,
            RenderPassTier? renderPassesTier = null,
            RaytracingTier? raytracingTier = null
        ) : this()
        {
            if (sRVOnlyTiledResourceTier3 is not null)
            {
                SRVOnlyTiledResourceTier3 = sRVOnlyTiledResourceTier3.Value;
            }

            if (renderPassesTier is not null)
            {
                RenderPassesTier = renderPassesTier.Value;
            }

            if (raytracingTier is not null)
            {
                RaytracingTier = raytracingTier.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "SRVOnlyTiledResourceTier3")]
        public Silk.NET.Core.Bool32 SRVOnlyTiledResourceTier3;

        [NativeName("Type", "D3D12_RENDER_PASS_TIER")]
        [NativeName("Type.Name", "D3D12_RENDER_PASS_TIER")]
        [NativeName("Name", "RenderPassesTier")]
        public RenderPassTier RenderPassesTier;

        [NativeName("Type", "D3D12_RAYTRACING_TIER")]
        [NativeName("Type.Name", "D3D12_RAYTRACING_TIER")]
        [NativeName("Name", "RaytracingTier")]
        public RaytracingTier RaytracingTier;
    }
}
