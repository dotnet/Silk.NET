// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_DEPTH_STENCIL_DESC2.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC2"]/*'/>
public partial struct D3D12_DEPTH_STENCIL_DESC2
{
    /// <include file='D3D12_DEPTH_STENCIL_DESC2.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC2.DepthEnable"]/*'/>
    public BOOL DepthEnable;
    /// <include file='D3D12_DEPTH_STENCIL_DESC2.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC2.DepthWriteMask"]/*'/>
    public D3D12_DEPTH_WRITE_MASK DepthWriteMask;
    /// <include file='D3D12_DEPTH_STENCIL_DESC2.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC2.DepthFunc"]/*'/>
    public D3D12_COMPARISON_FUNC DepthFunc;
    /// <include file='D3D12_DEPTH_STENCIL_DESC2.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC2.StencilEnable"]/*'/>
    public BOOL StencilEnable;
    /// <include file='D3D12_DEPTH_STENCIL_DESC2.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC2.FrontFace"]/*'/>
    public D3D12_DEPTH_STENCILOP_DESC1 FrontFace;
    /// <include file='D3D12_DEPTH_STENCIL_DESC2.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC2.BackFace"]/*'/>
    public D3D12_DEPTH_STENCILOP_DESC1 BackFace;
    /// <include file='D3D12_DEPTH_STENCIL_DESC2.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC2.DepthBoundsTestEnable"]/*'/>
    public BOOL DepthBoundsTestEnable;
}