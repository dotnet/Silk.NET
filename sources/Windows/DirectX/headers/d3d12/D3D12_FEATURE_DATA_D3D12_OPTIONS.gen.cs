// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS"]/*' />
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS
{
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.DoublePrecisionFloatShaderOps"]/*' />
    public BOOL DoublePrecisionFloatShaderOps;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.OutputMergerLogicOp"]/*' />
    public BOOL OutputMergerLogicOp;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.MinPrecisionSupport"]/*' />
    public D3D12_SHADER_MIN_PRECISION_SUPPORT MinPrecisionSupport;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.TiledResourcesTier"]/*' />
    public D3D12_TILED_RESOURCES_TIER TiledResourcesTier;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.ResourceBindingTier"]/*' />
    public D3D12_RESOURCE_BINDING_TIER ResourceBindingTier;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.PSSpecifiedStencilRefSupported"]/*' />
    public BOOL PSSpecifiedStencilRefSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.TypedUAVLoadAdditionalFormats"]/*' />
    public BOOL TypedUAVLoadAdditionalFormats;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.ROVsSupported"]/*' />
    public BOOL ROVsSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.ConservativeRasterizationTier"]/*' />
    public D3D12_CONSERVATIVE_RASTERIZATION_TIER ConservativeRasterizationTier;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.MaxGPUVirtualAddressBitsPerResource"]/*' />
    public uint MaxGPUVirtualAddressBitsPerResource;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.StandardSwizzle64KBSupported"]/*' />
    public BOOL StandardSwizzle64KBSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.CrossNodeSharingTier"]/*' />
    public D3D12_CROSS_NODE_SHARING_TIER CrossNodeSharingTier;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.CrossAdapterRowMajorTextureSupported"]/*' />
    public BOOL CrossAdapterRowMajorTextureSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.VPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation"]/*' />
    public BOOL VPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.ResourceHeapTier"]/*' />
    public D3D12_RESOURCE_HEAP_TIER ResourceHeapTier;
}
