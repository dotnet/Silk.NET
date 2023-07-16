// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_TEXTURE_ADDRESS_MODE.xml' path='doc/member[@name="D3D12_TEXTURE_ADDRESS_MODE"]/*'/>
public enum D3D12_TEXTURE_ADDRESS_MODE
{
    /// <include file='D3D12_TEXTURE_ADDRESS_MODE.xml' path='doc/member[@name="D3D12_TEXTURE_ADDRESS_MODE.D3D12_TEXTURE_ADDRESS_MODE_WRAP"]/*'/>
    D3D12_TEXTURE_ADDRESS_MODE_WRAP = 1,
    /// <include file='D3D12_TEXTURE_ADDRESS_MODE.xml' path='doc/member[@name="D3D12_TEXTURE_ADDRESS_MODE.D3D12_TEXTURE_ADDRESS_MODE_MIRROR"]/*'/>
    D3D12_TEXTURE_ADDRESS_MODE_MIRROR = 2,
    /// <include file='D3D12_TEXTURE_ADDRESS_MODE.xml' path='doc/member[@name="D3D12_TEXTURE_ADDRESS_MODE.D3D12_TEXTURE_ADDRESS_MODE_CLAMP"]/*'/>
    D3D12_TEXTURE_ADDRESS_MODE_CLAMP = 3,
    /// <include file='D3D12_TEXTURE_ADDRESS_MODE.xml' path='doc/member[@name="D3D12_TEXTURE_ADDRESS_MODE.D3D12_TEXTURE_ADDRESS_MODE_BORDER"]/*'/>
    D3D12_TEXTURE_ADDRESS_MODE_BORDER = 4,
    /// <include file='D3D12_TEXTURE_ADDRESS_MODE.xml' path='doc/member[@name="D3D12_TEXTURE_ADDRESS_MODE.D3D12_TEXTURE_ADDRESS_MODE_MIRROR_ONCE"]/*'/>
    D3D12_TEXTURE_ADDRESS_MODE_MIRROR_ONCE = 5,
}