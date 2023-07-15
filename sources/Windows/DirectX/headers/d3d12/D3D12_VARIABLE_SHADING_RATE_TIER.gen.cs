// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_VARIABLE_SHADING_RATE_TIER.xml' path='doc/member[@name="D3D12_VARIABLE_SHADING_RATE_TIER"]/*'/>
public enum D3D12_VARIABLE_SHADING_RATE_TIER
{
    /// <include file='D3D12_VARIABLE_SHADING_RATE_TIER.xml' path='doc/member[@name="D3D12_VARIABLE_SHADING_RATE_TIER.D3D12_VARIABLE_SHADING_RATE_TIER_NOT_SUPPORTED"]/*'/>
    D3D12_VARIABLE_SHADING_RATE_TIER_NOT_SUPPORTED = 0,
    /// <include file='D3D12_VARIABLE_SHADING_RATE_TIER.xml' path='doc/member[@name="D3D12_VARIABLE_SHADING_RATE_TIER.D3D12_VARIABLE_SHADING_RATE_TIER_1"]/*'/>
    D3D12_VARIABLE_SHADING_RATE_TIER_1 = 1,
    /// <include file='D3D12_VARIABLE_SHADING_RATE_TIER.xml' path='doc/member[@name="D3D12_VARIABLE_SHADING_RATE_TIER.D3D12_VARIABLE_SHADING_RATE_TIER_2"]/*'/>
    D3D12_VARIABLE_SHADING_RATE_TIER_2 = 2,
}