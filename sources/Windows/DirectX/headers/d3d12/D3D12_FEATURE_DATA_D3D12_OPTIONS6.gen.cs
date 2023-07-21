// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS6.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS6"]/*' />
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS6
{
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS6.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS6.AdditionalShadingRatesSupported"]/*' />
    public BOOL AdditionalShadingRatesSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS6.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS6.PerPrimitiveShadingRateSupportedWithViewportIndexing"]/*' />
    public BOOL PerPrimitiveShadingRateSupportedWithViewportIndexing;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS6.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS6.VariableShadingRateTier"]/*' />
    public D3D12_VARIABLE_SHADING_RATE_TIER VariableShadingRateTier;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS6.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS6.ShadingRateImageTileSize"]/*' />
    public uint ShadingRateImageTileSize;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS6.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS6.BackgroundProcessingSupported"]/*' />
    public BOOL BackgroundProcessingSupported;
}
