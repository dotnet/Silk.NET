// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_CROSS_NODE_SHARING_TIER.xml' path='doc/member[@name="D3D12_CROSS_NODE_SHARING_TIER"]/*'/>
public enum D3D12_CROSS_NODE_SHARING_TIER
{
    /// <include file='D3D12_CROSS_NODE_SHARING_TIER.xml' path='doc/member[@name="D3D12_CROSS_NODE_SHARING_TIER.D3D12_CROSS_NODE_SHARING_TIER_NOT_SUPPORTED"]/*'/>
    D3D12_CROSS_NODE_SHARING_TIER_NOT_SUPPORTED = 0,
    /// <include file='D3D12_CROSS_NODE_SHARING_TIER.xml' path='doc/member[@name="D3D12_CROSS_NODE_SHARING_TIER.D3D12_CROSS_NODE_SHARING_TIER_1_EMULATED"]/*'/>
    D3D12_CROSS_NODE_SHARING_TIER_1_EMULATED = 1,
    /// <include file='D3D12_CROSS_NODE_SHARING_TIER.xml' path='doc/member[@name="D3D12_CROSS_NODE_SHARING_TIER.D3D12_CROSS_NODE_SHARING_TIER_1"]/*'/>
    D3D12_CROSS_NODE_SHARING_TIER_1 = 2,
    /// <include file='D3D12_CROSS_NODE_SHARING_TIER.xml' path='doc/member[@name="D3D12_CROSS_NODE_SHARING_TIER.D3D12_CROSS_NODE_SHARING_TIER_2"]/*'/>
    D3D12_CROSS_NODE_SHARING_TIER_2 = 3,
    /// <include file='D3D12_CROSS_NODE_SHARING_TIER.xml' path='doc/member[@name="D3D12_CROSS_NODE_SHARING_TIER.D3D12_CROSS_NODE_SHARING_TIER_3"]/*'/>
    D3D12_CROSS_NODE_SHARING_TIER_3 = 4,
}