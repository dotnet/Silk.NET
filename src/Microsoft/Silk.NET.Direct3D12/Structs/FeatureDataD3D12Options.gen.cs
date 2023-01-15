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
    [NativeName("Name", "D3D12_FEATURE_DATA_D3D12_OPTIONS")]
    public unsafe partial struct FeatureDataD3D12Options
    {
        public FeatureDataD3D12Options
        (
            Silk.NET.Core.Bool32? doublePrecisionFloatShaderOps = null,
            Silk.NET.Core.Bool32? outputMergerLogicOp = null,
            ShaderMinPrecisionSupport? minPrecisionSupport = null,
            TiledResourcesTier? tiledResourcesTier = null,
            ResourceBindingTier? resourceBindingTier = null,
            Silk.NET.Core.Bool32? pSSpecifiedStencilRefSupported = null,
            Silk.NET.Core.Bool32? typedUAVLoadAdditionalFormats = null,
            Silk.NET.Core.Bool32? rOVsSupported = null,
            ConservativeRasterizationTier? conservativeRasterizationTier = null,
            uint? maxGPUVirtualAddressBitsPerResource = null,
            Silk.NET.Core.Bool32? standardSwizzle64KBSupported = null,
            CrossNodeSharingTier? crossNodeSharingTier = null,
            Silk.NET.Core.Bool32? crossAdapterRowMajorTextureSupported = null,
            Silk.NET.Core.Bool32? vPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation = null,
            ResourceHeapTier? resourceHeapTier = null
        ) : this()
        {
            if (doublePrecisionFloatShaderOps is not null)
            {
                DoublePrecisionFloatShaderOps = doublePrecisionFloatShaderOps.Value;
            }

            if (outputMergerLogicOp is not null)
            {
                OutputMergerLogicOp = outputMergerLogicOp.Value;
            }

            if (minPrecisionSupport is not null)
            {
                MinPrecisionSupport = minPrecisionSupport.Value;
            }

            if (tiledResourcesTier is not null)
            {
                TiledResourcesTier = tiledResourcesTier.Value;
            }

            if (resourceBindingTier is not null)
            {
                ResourceBindingTier = resourceBindingTier.Value;
            }

            if (pSSpecifiedStencilRefSupported is not null)
            {
                PSSpecifiedStencilRefSupported = pSSpecifiedStencilRefSupported.Value;
            }

            if (typedUAVLoadAdditionalFormats is not null)
            {
                TypedUAVLoadAdditionalFormats = typedUAVLoadAdditionalFormats.Value;
            }

            if (rOVsSupported is not null)
            {
                ROVsSupported = rOVsSupported.Value;
            }

            if (conservativeRasterizationTier is not null)
            {
                ConservativeRasterizationTier = conservativeRasterizationTier.Value;
            }

            if (maxGPUVirtualAddressBitsPerResource is not null)
            {
                MaxGPUVirtualAddressBitsPerResource = maxGPUVirtualAddressBitsPerResource.Value;
            }

            if (standardSwizzle64KBSupported is not null)
            {
                StandardSwizzle64KBSupported = standardSwizzle64KBSupported.Value;
            }

            if (crossNodeSharingTier is not null)
            {
                CrossNodeSharingTier = crossNodeSharingTier.Value;
            }

            if (crossAdapterRowMajorTextureSupported is not null)
            {
                CrossAdapterRowMajorTextureSupported = crossAdapterRowMajorTextureSupported.Value;
            }

            if (vPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation is not null)
            {
                VPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation = vPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation.Value;
            }

            if (resourceHeapTier is not null)
            {
                ResourceHeapTier = resourceHeapTier.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DoublePrecisionFloatShaderOps")]
        public Silk.NET.Core.Bool32 DoublePrecisionFloatShaderOps;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "OutputMergerLogicOp")]
        public Silk.NET.Core.Bool32 OutputMergerLogicOp;

        [NativeName("Type", "D3D12_SHADER_MIN_PRECISION_SUPPORT")]
        [NativeName("Type.Name", "D3D12_SHADER_MIN_PRECISION_SUPPORT")]
        [NativeName("Name", "MinPrecisionSupport")]
        public ShaderMinPrecisionSupport MinPrecisionSupport;

        [NativeName("Type", "D3D12_TILED_RESOURCES_TIER")]
        [NativeName("Type.Name", "D3D12_TILED_RESOURCES_TIER")]
        [NativeName("Name", "TiledResourcesTier")]
        public TiledResourcesTier TiledResourcesTier;

        [NativeName("Type", "D3D12_RESOURCE_BINDING_TIER")]
        [NativeName("Type.Name", "D3D12_RESOURCE_BINDING_TIER")]
        [NativeName("Name", "ResourceBindingTier")]
        public ResourceBindingTier ResourceBindingTier;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "PSSpecifiedStencilRefSupported")]
        public Silk.NET.Core.Bool32 PSSpecifiedStencilRefSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "TypedUAVLoadAdditionalFormats")]
        public Silk.NET.Core.Bool32 TypedUAVLoadAdditionalFormats;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ROVsSupported")]
        public Silk.NET.Core.Bool32 ROVsSupported;

        [NativeName("Type", "D3D12_CONSERVATIVE_RASTERIZATION_TIER")]
        [NativeName("Type.Name", "D3D12_CONSERVATIVE_RASTERIZATION_TIER")]
        [NativeName("Name", "ConservativeRasterizationTier")]
        public ConservativeRasterizationTier ConservativeRasterizationTier;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxGPUVirtualAddressBitsPerResource")]
        public uint MaxGPUVirtualAddressBitsPerResource;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "StandardSwizzle64KBSupported")]
        public Silk.NET.Core.Bool32 StandardSwizzle64KBSupported;

        [NativeName("Type", "D3D12_CROSS_NODE_SHARING_TIER")]
        [NativeName("Type.Name", "D3D12_CROSS_NODE_SHARING_TIER")]
        [NativeName("Name", "CrossNodeSharingTier")]
        public CrossNodeSharingTier CrossNodeSharingTier;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "CrossAdapterRowMajorTextureSupported")]
        public Silk.NET.Core.Bool32 CrossAdapterRowMajorTextureSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "VPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation")]
        public Silk.NET.Core.Bool32 VPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation;

        [NativeName("Type", "D3D12_RESOURCE_HEAP_TIER")]
        [NativeName("Type.Name", "D3D12_RESOURCE_HEAP_TIER")]
        [NativeName("Name", "ResourceHeapTier")]
        public ResourceHeapTier ResourceHeapTier;
    }
}
