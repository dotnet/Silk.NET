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
    [NativeName("Name", "D3D12_FEATURE_DATA_D3D12_OPTIONS19")]
    public unsafe partial struct FeatureDataD3D12Options19
    {
        public FeatureDataD3D12Options19
        (
            Silk.NET.Core.Bool32? mismatchingOutputDimensionsSupported = null,
            uint? supportedSampleCountsWithNoOutputs = null,
            Silk.NET.Core.Bool32? pointSamplingAddressesNeverRoundUp = null,
            Silk.NET.Core.Bool32? rasterizerDesc2Supported = null,
            Silk.NET.Core.Bool32? narrowQuadrilateralLinesSupported = null,
            Silk.NET.Core.Bool32? anisoFilterWithPointMipSupported = null,
            uint? maxSamplerDescriptorHeapSize = null,
            uint? maxSamplerDescriptorHeapSizeWithStaticSamplers = null,
            uint? maxViewDescriptorHeapSize = null,
            Silk.NET.Core.Bool32? computeOnlyCustomHeapSupported = null
        ) : this()
        {
            if (mismatchingOutputDimensionsSupported is not null)
            {
                MismatchingOutputDimensionsSupported = mismatchingOutputDimensionsSupported.Value;
            }

            if (supportedSampleCountsWithNoOutputs is not null)
            {
                SupportedSampleCountsWithNoOutputs = supportedSampleCountsWithNoOutputs.Value;
            }

            if (pointSamplingAddressesNeverRoundUp is not null)
            {
                PointSamplingAddressesNeverRoundUp = pointSamplingAddressesNeverRoundUp.Value;
            }

            if (rasterizerDesc2Supported is not null)
            {
                RasterizerDesc2Supported = rasterizerDesc2Supported.Value;
            }

            if (narrowQuadrilateralLinesSupported is not null)
            {
                NarrowQuadrilateralLinesSupported = narrowQuadrilateralLinesSupported.Value;
            }

            if (anisoFilterWithPointMipSupported is not null)
            {
                AnisoFilterWithPointMipSupported = anisoFilterWithPointMipSupported.Value;
            }

            if (maxSamplerDescriptorHeapSize is not null)
            {
                MaxSamplerDescriptorHeapSize = maxSamplerDescriptorHeapSize.Value;
            }

            if (maxSamplerDescriptorHeapSizeWithStaticSamplers is not null)
            {
                MaxSamplerDescriptorHeapSizeWithStaticSamplers = maxSamplerDescriptorHeapSizeWithStaticSamplers.Value;
            }

            if (maxViewDescriptorHeapSize is not null)
            {
                MaxViewDescriptorHeapSize = maxViewDescriptorHeapSize.Value;
            }

            if (computeOnlyCustomHeapSupported is not null)
            {
                ComputeOnlyCustomHeapSupported = computeOnlyCustomHeapSupported.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "MismatchingOutputDimensionsSupported")]
        public Silk.NET.Core.Bool32 MismatchingOutputDimensionsSupported;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SupportedSampleCountsWithNoOutputs")]
        public uint SupportedSampleCountsWithNoOutputs;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "PointSamplingAddressesNeverRoundUp")]
        public Silk.NET.Core.Bool32 PointSamplingAddressesNeverRoundUp;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "RasterizerDesc2Supported")]
        public Silk.NET.Core.Bool32 RasterizerDesc2Supported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "NarrowQuadrilateralLinesSupported")]
        public Silk.NET.Core.Bool32 NarrowQuadrilateralLinesSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "AnisoFilterWithPointMipSupported")]
        public Silk.NET.Core.Bool32 AnisoFilterWithPointMipSupported;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxSamplerDescriptorHeapSize")]
        public uint MaxSamplerDescriptorHeapSize;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxSamplerDescriptorHeapSizeWithStaticSamplers")]
        public uint MaxSamplerDescriptorHeapSizeWithStaticSamplers;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxViewDescriptorHeapSize")]
        public uint MaxViewDescriptorHeapSize;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ComputeOnlyCustomHeapSupported")]
        public Silk.NET.Core.Bool32 ComputeOnlyCustomHeapSupported;
    }
}
