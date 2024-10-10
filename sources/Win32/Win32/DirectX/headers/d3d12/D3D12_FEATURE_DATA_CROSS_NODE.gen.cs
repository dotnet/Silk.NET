// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_CROSS_NODE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_CROSS_NODE"]/*'/>
public partial struct D3D12_FEATURE_DATA_CROSS_NODE
{
    /// <include file='D3D12_FEATURE_DATA_CROSS_NODE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_CROSS_NODE.SharingTier"]/*'/>

    public D3D12_CROSS_NODE_SHARING_TIER SharingTier;

    /// <include file='D3D12_FEATURE_DATA_CROSS_NODE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_CROSS_NODE.AtomicShaderInstructions"]/*'/>

    public BOOL AtomicShaderInstructions;
}
