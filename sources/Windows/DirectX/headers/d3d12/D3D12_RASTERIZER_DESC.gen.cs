// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_RASTERIZER_DESC.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC"]/*'/>
public partial struct D3D12_RASTERIZER_DESC
{
    /// <include file='D3D12_RASTERIZER_DESC.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC.FillMode"]/*'/>
    public D3D12_FILL_MODE FillMode;
    /// <include file='D3D12_RASTERIZER_DESC.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC.CullMode"]/*'/>
    public D3D12_CULL_MODE CullMode;
    /// <include file='D3D12_RASTERIZER_DESC.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC.FrontCounterClockwise"]/*'/>
    public BOOL FrontCounterClockwise;
    /// <include file='D3D12_RASTERIZER_DESC.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC.DepthBias"]/*'/>
    public int DepthBias;
    /// <include file='D3D12_RASTERIZER_DESC.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC.DepthBiasClamp"]/*'/>
    public float DepthBiasClamp;
    /// <include file='D3D12_RASTERIZER_DESC.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC.SlopeScaledDepthBias"]/*'/>
    public float SlopeScaledDepthBias;
    /// <include file='D3D12_RASTERIZER_DESC.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC.DepthClipEnable"]/*'/>
    public BOOL DepthClipEnable;
    /// <include file='D3D12_RASTERIZER_DESC.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC.MultisampleEnable"]/*'/>
    public BOOL MultisampleEnable;
    /// <include file='D3D12_RASTERIZER_DESC.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC.AntialiasedLineEnable"]/*'/>
    public BOOL AntialiasedLineEnable;
    /// <include file='D3D12_RASTERIZER_DESC.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC.ForcedSampleCount"]/*'/>
    public uint ForcedSampleCount;
    /// <include file='D3D12_RASTERIZER_DESC.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC.ConservativeRaster"]/*'/>
    public D3D12_CONSERVATIVE_RASTERIZATION_MODE ConservativeRaster;
}