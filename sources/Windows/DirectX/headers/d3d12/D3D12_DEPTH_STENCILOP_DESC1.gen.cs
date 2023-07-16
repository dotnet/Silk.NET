// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_DEPTH_STENCILOP_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCILOP_DESC1"]/*'/>
public partial struct D3D12_DEPTH_STENCILOP_DESC1
{
    /// <include file='D3D12_DEPTH_STENCILOP_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCILOP_DESC1.StencilFailOp"]/*'/>
    public D3D12_STENCIL_OP StencilFailOp;
    /// <include file='D3D12_DEPTH_STENCILOP_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCILOP_DESC1.StencilDepthFailOp"]/*'/>
    public D3D12_STENCIL_OP StencilDepthFailOp;
    /// <include file='D3D12_DEPTH_STENCILOP_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCILOP_DESC1.StencilPassOp"]/*'/>
    public D3D12_STENCIL_OP StencilPassOp;
    /// <include file='D3D12_DEPTH_STENCILOP_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCILOP_DESC1.StencilFunc"]/*'/>
    public D3D12_COMPARISON_FUNC StencilFunc;
    /// <include file='D3D12_DEPTH_STENCILOP_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCILOP_DESC1.StencilReadMask"]/*'/>
    [NativeTypeName("UINT8")]
    public byte StencilReadMask;
    /// <include file='D3D12_DEPTH_STENCILOP_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCILOP_DESC1.StencilWriteMask"]/*'/>
    [NativeTypeName("UINT8")]
    public byte StencilWriteMask;
}