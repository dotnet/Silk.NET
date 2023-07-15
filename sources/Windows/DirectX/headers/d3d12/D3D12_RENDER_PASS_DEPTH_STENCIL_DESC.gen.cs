// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_RENDER_PASS_DEPTH_STENCIL_DESC.xml' path='doc/member[@name="D3D12_RENDER_PASS_DEPTH_STENCIL_DESC"]/*'/>
public partial struct D3D12_RENDER_PASS_DEPTH_STENCIL_DESC
{
    /// <include file='D3D12_RENDER_PASS_DEPTH_STENCIL_DESC.xml' path='doc/member[@name="D3D12_RENDER_PASS_DEPTH_STENCIL_DESC.cpuDescriptor"]/*'/>
    public D3D12_CPU_DESCRIPTOR_HANDLE cpuDescriptor;
    /// <include file='D3D12_RENDER_PASS_DEPTH_STENCIL_DESC.xml' path='doc/member[@name="D3D12_RENDER_PASS_DEPTH_STENCIL_DESC.DepthBeginningAccess"]/*'/>
    public D3D12_RENDER_PASS_BEGINNING_ACCESS DepthBeginningAccess;
    /// <include file='D3D12_RENDER_PASS_DEPTH_STENCIL_DESC.xml' path='doc/member[@name="D3D12_RENDER_PASS_DEPTH_STENCIL_DESC.StencilBeginningAccess"]/*'/>
    public D3D12_RENDER_PASS_BEGINNING_ACCESS StencilBeginningAccess;
    /// <include file='D3D12_RENDER_PASS_DEPTH_STENCIL_DESC.xml' path='doc/member[@name="D3D12_RENDER_PASS_DEPTH_STENCIL_DESC.DepthEndingAccess"]/*'/>
    public D3D12_RENDER_PASS_ENDING_ACCESS DepthEndingAccess;
    /// <include file='D3D12_RENDER_PASS_DEPTH_STENCIL_DESC.xml' path='doc/member[@name="D3D12_RENDER_PASS_DEPTH_STENCIL_DESC.StencilEndingAccess"]/*'/>
    public D3D12_RENDER_PASS_ENDING_ACCESS StencilEndingAccess;
}