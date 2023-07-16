// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D3D10_TEXTURE_ADDRESS_MODE.xml' path='doc/member[@name="D3D10_TEXTURE_ADDRESS_MODE"]/*'/>
public enum D3D10_TEXTURE_ADDRESS_MODE
{
    /// <include file='D3D10_TEXTURE_ADDRESS_MODE.xml' path='doc/member[@name="D3D10_TEXTURE_ADDRESS_MODE.D3D10_TEXTURE_ADDRESS_WRAP"]/*'/>
    D3D10_TEXTURE_ADDRESS_WRAP = 1,
    /// <include file='D3D10_TEXTURE_ADDRESS_MODE.xml' path='doc/member[@name="D3D10_TEXTURE_ADDRESS_MODE.D3D10_TEXTURE_ADDRESS_MIRROR"]/*'/>
    D3D10_TEXTURE_ADDRESS_MIRROR = 2,
    /// <include file='D3D10_TEXTURE_ADDRESS_MODE.xml' path='doc/member[@name="D3D10_TEXTURE_ADDRESS_MODE.D3D10_TEXTURE_ADDRESS_CLAMP"]/*'/>
    D3D10_TEXTURE_ADDRESS_CLAMP = 3,
    /// <include file='D3D10_TEXTURE_ADDRESS_MODE.xml' path='doc/member[@name="D3D10_TEXTURE_ADDRESS_MODE.D3D10_TEXTURE_ADDRESS_BORDER"]/*'/>
    D3D10_TEXTURE_ADDRESS_BORDER = 4,
    /// <include file='D3D10_TEXTURE_ADDRESS_MODE.xml' path='doc/member[@name="D3D10_TEXTURE_ADDRESS_MODE.D3D10_TEXTURE_ADDRESS_MIRROR_ONCE"]/*'/>
    D3D10_TEXTURE_ADDRESS_MIRROR_ONCE = 5,
}