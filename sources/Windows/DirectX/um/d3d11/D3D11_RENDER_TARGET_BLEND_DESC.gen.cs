// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='D3D11_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D11_RENDER_TARGET_BLEND_DESC"]/*' />
public partial struct D3D11_RENDER_TARGET_BLEND_DESC
{
    /// <include file='D3D11_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D11_RENDER_TARGET_BLEND_DESC.BlendEnable"]/*' />
    public BOOL BlendEnable;

    /// <include file='D3D11_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D11_RENDER_TARGET_BLEND_DESC.SrcBlend"]/*' />
    public D3D11_BLEND SrcBlend;

    /// <include file='D3D11_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D11_RENDER_TARGET_BLEND_DESC.DestBlend"]/*' />
    public D3D11_BLEND DestBlend;

    /// <include file='D3D11_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D11_RENDER_TARGET_BLEND_DESC.BlendOp"]/*' />
    public D3D11_BLEND_OP BlendOp;

    /// <include file='D3D11_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D11_RENDER_TARGET_BLEND_DESC.SrcBlendAlpha"]/*' />
    public D3D11_BLEND SrcBlendAlpha;

    /// <include file='D3D11_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D11_RENDER_TARGET_BLEND_DESC.DestBlendAlpha"]/*' />
    public D3D11_BLEND DestBlendAlpha;

    /// <include file='D3D11_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D11_RENDER_TARGET_BLEND_DESC.BlendOpAlpha"]/*' />
    public D3D11_BLEND_OP BlendOpAlpha;

    /// <include file='D3D11_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D11_RENDER_TARGET_BLEND_DESC.RenderTargetWriteMask"]/*' />
    [NativeTypeName("UINT8")]
    public byte RenderTargetWriteMask;
}
