// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D10_RENDER_TARGET_BLEND_DESC1.xml' path='doc/member[@name="D3D10_RENDER_TARGET_BLEND_DESC1"]/*'/>
public partial struct D3D10_RENDER_TARGET_BLEND_DESC1
{
    /// <include file='D3D10_RENDER_TARGET_BLEND_DESC1.xml' path='doc/member[@name="D3D10_RENDER_TARGET_BLEND_DESC1.BlendEnable"]/*'/>
    public BOOL BlendEnable;
    /// <include file='D3D10_RENDER_TARGET_BLEND_DESC1.xml' path='doc/member[@name="D3D10_RENDER_TARGET_BLEND_DESC1.SrcBlend"]/*'/>
    public D3D10_BLEND SrcBlend;
    /// <include file='D3D10_RENDER_TARGET_BLEND_DESC1.xml' path='doc/member[@name="D3D10_RENDER_TARGET_BLEND_DESC1.DestBlend"]/*'/>
    public D3D10_BLEND DestBlend;
    /// <include file='D3D10_RENDER_TARGET_BLEND_DESC1.xml' path='doc/member[@name="D3D10_RENDER_TARGET_BLEND_DESC1.BlendOp"]/*'/>
    public D3D10_BLEND_OP BlendOp;
    /// <include file='D3D10_RENDER_TARGET_BLEND_DESC1.xml' path='doc/member[@name="D3D10_RENDER_TARGET_BLEND_DESC1.SrcBlendAlpha"]/*'/>
    public D3D10_BLEND SrcBlendAlpha;
    /// <include file='D3D10_RENDER_TARGET_BLEND_DESC1.xml' path='doc/member[@name="D3D10_RENDER_TARGET_BLEND_DESC1.DestBlendAlpha"]/*'/>
    public D3D10_BLEND DestBlendAlpha;
    /// <include file='D3D10_RENDER_TARGET_BLEND_DESC1.xml' path='doc/member[@name="D3D10_RENDER_TARGET_BLEND_DESC1.BlendOpAlpha"]/*'/>
    public D3D10_BLEND_OP BlendOpAlpha;
    /// <include file='D3D10_RENDER_TARGET_BLEND_DESC1.xml' path='doc/member[@name="D3D10_RENDER_TARGET_BLEND_DESC1.RenderTargetWriteMask"]/*'/>
    [NativeTypeName("UINT8")]
    public byte RenderTargetWriteMask;
}