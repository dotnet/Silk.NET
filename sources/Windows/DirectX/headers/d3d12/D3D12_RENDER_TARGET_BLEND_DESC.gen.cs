// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D12_RENDER_TARGET_BLEND_DESC"]/*'/>
public partial struct D3D12_RENDER_TARGET_BLEND_DESC
{
    /// <include file='D3D12_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D12_RENDER_TARGET_BLEND_DESC.BlendEnable"]/*'/>
    public BOOL BlendEnable;
    /// <include file='D3D12_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D12_RENDER_TARGET_BLEND_DESC.LogicOpEnable"]/*'/>
    public BOOL LogicOpEnable;
    /// <include file='D3D12_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D12_RENDER_TARGET_BLEND_DESC.SrcBlend"]/*'/>
    public D3D12_BLEND SrcBlend;
    /// <include file='D3D12_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D12_RENDER_TARGET_BLEND_DESC.DestBlend"]/*'/>
    public D3D12_BLEND DestBlend;
    /// <include file='D3D12_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D12_RENDER_TARGET_BLEND_DESC.BlendOp"]/*'/>
    public D3D12_BLEND_OP BlendOp;
    /// <include file='D3D12_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D12_RENDER_TARGET_BLEND_DESC.SrcBlendAlpha"]/*'/>
    public D3D12_BLEND SrcBlendAlpha;
    /// <include file='D3D12_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D12_RENDER_TARGET_BLEND_DESC.DestBlendAlpha"]/*'/>
    public D3D12_BLEND DestBlendAlpha;
    /// <include file='D3D12_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D12_RENDER_TARGET_BLEND_DESC.BlendOpAlpha"]/*'/>
    public D3D12_BLEND_OP BlendOpAlpha;
    /// <include file='D3D12_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D12_RENDER_TARGET_BLEND_DESC.LogicOp"]/*'/>
    public D3D12_LOGIC_OP LogicOp;
    /// <include file='D3D12_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D12_RENDER_TARGET_BLEND_DESC.RenderTargetWriteMask"]/*'/>
    [NativeTypeName("UINT8")]
    public byte RenderTargetWriteMask;
}