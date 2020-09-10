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
    [NativeName("Name", "D3D12_FEATURE_DATA_D3D12_OPTIONS")]
    public unsafe partial struct FeatureDataD3D12Options
    {
        public FeatureDataD3D12Options
        (
            int doublePrecisionFloatShaderOps = default,
            int outputMergerLogicOp = default,
            ShaderMinPrecisionSupport minPrecisionSupport = default,
            TiledResourcesTier tiledResourcesTier = default,
            ResourceBindingTier resourceBindingTier = default,
            int pSSpecifiedStencilRefSupported = default,
            int typedUAVLoadAdditionalFormats = default,
            int rOVsSupported = default,
            ConservativeRasterizationTier conservativeRasterizationTier = default,
            uint maxGPUVirtualAddressBitsPerResource = default,
            int standardSwizzle64KBSupported = default,
            CrossNodeSharingTier crossNodeSharingTier = default,
            int crossAdapterRowMajorTextureSupported = default,
            int vPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation = default,
            ResourceHeapTier resourceHeapTier = default
        )
        {
            DoublePrecisionFloatShaderOps = doublePrecisionFloatShaderOps;
            OutputMergerLogicOp = outputMergerLogicOp;
            MinPrecisionSupport = minPrecisionSupport;
            TiledResourcesTier = tiledResourcesTier;
            ResourceBindingTier = resourceBindingTier;
            PSSpecifiedStencilRefSupported = pSSpecifiedStencilRefSupported;
            TypedUAVLoadAdditionalFormats = typedUAVLoadAdditionalFormats;
            ROVsSupported = rOVsSupported;
            ConservativeRasterizationTier = conservativeRasterizationTier;
            MaxGPUVirtualAddressBitsPerResource = maxGPUVirtualAddressBitsPerResource;
            StandardSwizzle64KBSupported = standardSwizzle64KBSupported;
            CrossNodeSharingTier = crossNodeSharingTier;
            CrossAdapterRowMajorTextureSupported = crossAdapterRowMajorTextureSupported;
            VPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation = vPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation;
            ResourceHeapTier = resourceHeapTier;
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DoublePrecisionFloatShaderOps")]
        public int DoublePrecisionFloatShaderOps;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "OutputMergerLogicOp")]
        public int OutputMergerLogicOp;

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
        public int PSSpecifiedStencilRefSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "TypedUAVLoadAdditionalFormats")]
        public int TypedUAVLoadAdditionalFormats;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ROVsSupported")]
        public int ROVsSupported;

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
        public int StandardSwizzle64KBSupported;

        [NativeName("Type", "D3D12_CROSS_NODE_SHARING_TIER")]
        [NativeName("Type.Name", "D3D12_CROSS_NODE_SHARING_TIER")]
        [NativeName("Name", "CrossNodeSharingTier")]
        public CrossNodeSharingTier CrossNodeSharingTier;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "CrossAdapterRowMajorTextureSupported")]
        public int CrossAdapterRowMajorTextureSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "VPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation")]
        public int VPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation;

        [NativeName("Type", "D3D12_RESOURCE_HEAP_TIER")]
        [NativeName("Type.Name", "D3D12_RESOURCE_HEAP_TIER")]
        [NativeName("Name", "ResourceHeapTier")]
        public ResourceHeapTier ResourceHeapTier;
    }
}
