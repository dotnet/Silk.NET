// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D3D11_BLEND_OP.xml' path='doc/member[@name="D3D11_BLEND_OP"]/*'/>
public enum D3D11_BLEND_OP
{
    /// <include file='D3D11_BLEND_OP.xml' path='doc/member[@name="D3D11_BLEND_OP.D3D11_BLEND_OP_ADD"]/*'/>
    D3D11_BLEND_OP_ADD = 1,
    /// <include file='D3D11_BLEND_OP.xml' path='doc/member[@name="D3D11_BLEND_OP.D3D11_BLEND_OP_SUBTRACT"]/*'/>
    D3D11_BLEND_OP_SUBTRACT = 2,
    /// <include file='D3D11_BLEND_OP.xml' path='doc/member[@name="D3D11_BLEND_OP.D3D11_BLEND_OP_REV_SUBTRACT"]/*'/>
    D3D11_BLEND_OP_REV_SUBTRACT = 3,
    /// <include file='D3D11_BLEND_OP.xml' path='doc/member[@name="D3D11_BLEND_OP.D3D11_BLEND_OP_MIN"]/*'/>
    D3D11_BLEND_OP_MIN = 4,
    /// <include file='D3D11_BLEND_OP.xml' path='doc/member[@name="D3D11_BLEND_OP.D3D11_BLEND_OP_MAX"]/*'/>
    D3D11_BLEND_OP_MAX = 5,
}