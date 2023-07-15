// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_SHARED_RESOURCE_TIER.xml' path='doc/member[@name="D3D11_SHARED_RESOURCE_TIER"]/*'/>
public enum D3D11_SHARED_RESOURCE_TIER
{
    /// <include file='D3D11_SHARED_RESOURCE_TIER.xml' path='doc/member[@name="D3D11_SHARED_RESOURCE_TIER.D3D11_SHARED_RESOURCE_TIER_0"]/*'/>
    D3D11_SHARED_RESOURCE_TIER_0 = 0,
    /// <include file='D3D11_SHARED_RESOURCE_TIER.xml' path='doc/member[@name="D3D11_SHARED_RESOURCE_TIER.D3D11_SHARED_RESOURCE_TIER_1"]/*'/>
    D3D11_SHARED_RESOURCE_TIER_1 = (D3D11_SHARED_RESOURCE_TIER_0 + 1),
    /// <include file='D3D11_SHARED_RESOURCE_TIER.xml' path='doc/member[@name="D3D11_SHARED_RESOURCE_TIER.D3D11_SHARED_RESOURCE_TIER_2"]/*'/>
    D3D11_SHARED_RESOURCE_TIER_2 = (D3D11_SHARED_RESOURCE_TIER_1 + 1),
    /// <include file='D3D11_SHARED_RESOURCE_TIER.xml' path='doc/member[@name="D3D11_SHARED_RESOURCE_TIER.D3D11_SHARED_RESOURCE_TIER_3"]/*'/>
    D3D11_SHARED_RESOURCE_TIER_3 = (D3D11_SHARED_RESOURCE_TIER_2 + 1),
}