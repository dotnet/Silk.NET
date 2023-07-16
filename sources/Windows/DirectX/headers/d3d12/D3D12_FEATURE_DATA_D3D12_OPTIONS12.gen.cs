// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;

namespace Silk.NET.DirectX;
/// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS12.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS12"]/*'/>
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS12
{
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS12.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS12.MSPrimitivesPipelineStatisticIncludesCulledPrimitives"]/*'/>
    public D3D12_TRI_STATE MSPrimitivesPipelineStatisticIncludesCulledPrimitives;
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS12.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS12.EnhancedBarriersSupported"]/*'/>
    public BOOL EnhancedBarriersSupported;
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS12.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS12.RelaxedFormatCastingSupported"]/*'/>
    public BOOL RelaxedFormatCastingSupported;
}