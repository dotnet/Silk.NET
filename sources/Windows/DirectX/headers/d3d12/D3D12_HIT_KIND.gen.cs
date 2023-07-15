// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_HIT_KIND.xml' path='doc/member[@name="D3D12_HIT_KIND"]/*'/>
public enum D3D12_HIT_KIND
{
    /// <include file='D3D12_HIT_KIND.xml' path='doc/member[@name="D3D12_HIT_KIND.D3D12_HIT_KIND_TRIANGLE_FRONT_FACE"]/*'/>
    D3D12_HIT_KIND_TRIANGLE_FRONT_FACE = 0xfe,
    /// <include file='D3D12_HIT_KIND.xml' path='doc/member[@name="D3D12_HIT_KIND.D3D12_HIT_KIND_TRIANGLE_BACK_FACE"]/*'/>
    D3D12_HIT_KIND_TRIANGLE_BACK_FACE = 0xff,
}