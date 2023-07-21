// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='D3D11_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC2"]/*' />
public partial struct D3D11_RASTERIZER_DESC2
{
    /// <include file='D3D11_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC2.FillMode"]/*' />
    public D3D11_FILL_MODE FillMode;

    /// <include file='D3D11_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC2.CullMode"]/*' />
    public D3D11_CULL_MODE CullMode;

    /// <include file='D3D11_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC2.FrontCounterClockwise"]/*' />
    public BOOL FrontCounterClockwise;

    /// <include file='D3D11_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC2.DepthBias"]/*' />
    public int DepthBias;

    /// <include file='D3D11_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC2.DepthBiasClamp"]/*' />
    public float DepthBiasClamp;

    /// <include file='D3D11_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC2.SlopeScaledDepthBias"]/*' />
    public float SlopeScaledDepthBias;

    /// <include file='D3D11_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC2.DepthClipEnable"]/*' />
    public BOOL DepthClipEnable;

    /// <include file='D3D11_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC2.ScissorEnable"]/*' />
    public BOOL ScissorEnable;

    /// <include file='D3D11_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC2.MultisampleEnable"]/*' />
    public BOOL MultisampleEnable;

    /// <include file='D3D11_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC2.AntialiasedLineEnable"]/*' />
    public BOOL AntialiasedLineEnable;

    /// <include file='D3D11_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC2.ForcedSampleCount"]/*' />
    public uint ForcedSampleCount;

    /// <include file='D3D11_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D11_RASTERIZER_DESC2.ConservativeRaster"]/*' />
    public D3D11_CONSERVATIVE_RASTERIZATION_MODE ConservativeRaster;
}
