// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;

namespace Silk.NET.DirectX;
/// <include file='D3D12_DEPTH_STENCIL_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC1"]/*'/>
public partial struct D3D12_DEPTH_STENCIL_DESC1
{
    /// <include file='D3D12_DEPTH_STENCIL_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC1.DepthEnable"]/*'/>
    public BOOL DepthEnable;
    /// <include file='D3D12_DEPTH_STENCIL_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC1.DepthWriteMask"]/*'/>
    public D3D12_DEPTH_WRITE_MASK DepthWriteMask;
    /// <include file='D3D12_DEPTH_STENCIL_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC1.DepthFunc"]/*'/>
    public D3D12_COMPARISON_FUNC DepthFunc;
    /// <include file='D3D12_DEPTH_STENCIL_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC1.StencilEnable"]/*'/>
    public BOOL StencilEnable;
    /// <include file='D3D12_DEPTH_STENCIL_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC1.StencilReadMask"]/*'/>
    [NativeTypeName("UINT8")]
    public byte StencilReadMask;
    /// <include file='D3D12_DEPTH_STENCIL_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC1.StencilWriteMask"]/*'/>
    [NativeTypeName("UINT8")]
    public byte StencilWriteMask;
    /// <include file='D3D12_DEPTH_STENCIL_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC1.FrontFace"]/*'/>
    public D3D12_DEPTH_STENCILOP_DESC FrontFace;
    /// <include file='D3D12_DEPTH_STENCIL_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC1.BackFace"]/*'/>
    public D3D12_DEPTH_STENCILOP_DESC BackFace;
    /// <include file='D3D12_DEPTH_STENCIL_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC1.DepthBoundsTestEnable"]/*'/>
    public BOOL DepthBoundsTestEnable;
}