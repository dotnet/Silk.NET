// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='D3D11_RASTERIZER_DESC.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC"]/*' />
public partial struct D3D11_RASTERIZER_DESC
{
    /// <include file='D3D11_RASTERIZER_DESC.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC.FillMode"]/*' />
    public D3D11_FILL_MODE FillMode;

    /// <include file='D3D11_RASTERIZER_DESC.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC.CullMode"]/*' />
    public D3D11_CULL_MODE CullMode;

    /// <include file='D3D11_RASTERIZER_DESC.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC.FrontCounterClockwise"]/*' />
    public BOOL FrontCounterClockwise;

    /// <include file='D3D11_RASTERIZER_DESC.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC.DepthBias"]/*' />
    public int DepthBias;

    /// <include file='D3D11_RASTERIZER_DESC.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC.DepthBiasClamp"]/*' />
    public float DepthBiasClamp;

    /// <include file='D3D11_RASTERIZER_DESC.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC.SlopeScaledDepthBias"]/*' />
    public float SlopeScaledDepthBias;

    /// <include file='D3D11_RASTERIZER_DESC.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC.DepthClipEnable"]/*' />
    public BOOL DepthClipEnable;

    /// <include file='D3D11_RASTERIZER_DESC.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC.ScissorEnable"]/*' />
    public BOOL ScissorEnable;

    /// <include file='D3D11_RASTERIZER_DESC.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC.MultisampleEnable"]/*' />
    public BOOL MultisampleEnable;

    /// <include file='D3D11_RASTERIZER_DESC.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC.AntialiasedLineEnable"]/*' />
    public BOOL AntialiasedLineEnable;
}
