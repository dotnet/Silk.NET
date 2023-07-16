// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D3D11_CONSERVATIVE_RASTERIZATION_TIER.xml' path='doc/member[@name="D3D11_CONSERVATIVE_RASTERIZATION_TIER"]/*'/>
[SupportedOSPlatform("windows10.0")]
public enum D3D11_CONSERVATIVE_RASTERIZATION_TIER
{
    /// <include file='D3D11_CONSERVATIVE_RASTERIZATION_TIER.xml' path='doc/member[@name="D3D11_CONSERVATIVE_RASTERIZATION_TIER.D3D11_CONSERVATIVE_RASTERIZATION_NOT_SUPPORTED"]/*'/>
    D3D11_CONSERVATIVE_RASTERIZATION_NOT_SUPPORTED = 0,
    /// <include file='D3D11_CONSERVATIVE_RASTERIZATION_TIER.xml' path='doc/member[@name="D3D11_CONSERVATIVE_RASTERIZATION_TIER.D3D11_CONSERVATIVE_RASTERIZATION_TIER_1"]/*'/>
    D3D11_CONSERVATIVE_RASTERIZATION_TIER_1 = 1,
    /// <include file='D3D11_CONSERVATIVE_RASTERIZATION_TIER.xml' path='doc/member[@name="D3D11_CONSERVATIVE_RASTERIZATION_TIER.D3D11_CONSERVATIVE_RASTERIZATION_TIER_2"]/*'/>
    D3D11_CONSERVATIVE_RASTERIZATION_TIER_2 = 2,
    /// <include file='D3D11_CONSERVATIVE_RASTERIZATION_TIER.xml' path='doc/member[@name="D3D11_CONSERVATIVE_RASTERIZATION_TIER.D3D11_CONSERVATIVE_RASTERIZATION_TIER_3"]/*'/>
    D3D11_CONSERVATIVE_RASTERIZATION_TIER_3 = 3,
}