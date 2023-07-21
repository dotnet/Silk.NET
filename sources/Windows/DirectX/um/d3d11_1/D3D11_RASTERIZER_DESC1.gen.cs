// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='D3D11_RASTERIZER_DESC1.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC1"]/*' />
public partial struct D3D11_RASTERIZER_DESC1
{
    /// <include file='D3D11_RASTERIZER_DESC1.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC1.FillMode"]/*' />
    public D3D11_FILL_MODE FillMode;

    /// <include file='D3D11_RASTERIZER_DESC1.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC1.CullMode"]/*' />
    public D3D11_CULL_MODE CullMode;

    /// <include file='D3D11_RASTERIZER_DESC1.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC1.FrontCounterClockwise"]/*' />
    public BOOL FrontCounterClockwise;

    /// <include file='D3D11_RASTERIZER_DESC1.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC1.DepthBias"]/*' />
    public int DepthBias;

    /// <include file='D3D11_RASTERIZER_DESC1.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC1.DepthBiasClamp"]/*' />
    public float DepthBiasClamp;

    /// <include file='D3D11_RASTERIZER_DESC1.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC1.SlopeScaledDepthBias"]/*' />
    public float SlopeScaledDepthBias;

    /// <include file='D3D11_RASTERIZER_DESC1.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC1.DepthClipEnable"]/*' />
    public BOOL DepthClipEnable;

    /// <include file='D3D11_RASTERIZER_DESC1.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC1.ScissorEnable"]/*' />
    public BOOL ScissorEnable;

    /// <include file='D3D11_RASTERIZER_DESC1.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC1.MultisampleEnable"]/*' />
    public BOOL MultisampleEnable;

    /// <include file='D3D11_RASTERIZER_DESC1.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC1.AntialiasedLineEnable"]/*' />
    public BOOL AntialiasedLineEnable;

    /// <include file='D3D11_RASTERIZER_DESC1.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC1.ForcedSampleCount"]/*' />
    public uint ForcedSampleCount;
}
