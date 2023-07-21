// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS4.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS4"]/*' />
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS4
{
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS4.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS4.MSAA64KBAlignedTextureSupported"]/*' />
    public BOOL MSAA64KBAlignedTextureSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS4.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS4.SharedResourceCompatibilityTier"]/*' />
    public D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER SharedResourceCompatibilityTier;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS4.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS4.Native16BitShaderOpsSupported"]/*' />
    public BOOL Native16BitShaderOpsSupported;
}
