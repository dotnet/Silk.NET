// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D3D10_DEPTH_STENCILOP_DESC.xml' path='doc/member[@name="D3D10_DEPTH_STENCILOP_DESC"]/*'/>
public partial struct D3D10_DEPTH_STENCILOP_DESC
{
    /// <include file='D3D10_DEPTH_STENCILOP_DESC.xml' path='doc/member[@name="D3D10_DEPTH_STENCILOP_DESC.StencilFailOp"]/*'/>
    public D3D10_STENCIL_OP StencilFailOp;
    /// <include file='D3D10_DEPTH_STENCILOP_DESC.xml' path='doc/member[@name="D3D10_DEPTH_STENCILOP_DESC.StencilDepthFailOp"]/*'/>
    public D3D10_STENCIL_OP StencilDepthFailOp;
    /// <include file='D3D10_DEPTH_STENCILOP_DESC.xml' path='doc/member[@name="D3D10_DEPTH_STENCILOP_DESC.StencilPassOp"]/*'/>
    public D3D10_STENCIL_OP StencilPassOp;
    /// <include file='D3D10_DEPTH_STENCILOP_DESC.xml' path='doc/member[@name="D3D10_DEPTH_STENCILOP_DESC.StencilFunc"]/*'/>
    public D3D10_COMPARISON_FUNC StencilFunc;
}