// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System.Runtime.CompilerServices;

namespace Silk.NET.DirectX;

/// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC"]/*'/>
public unsafe partial struct D3D12_GRAPHICS_PIPELINE_STATE_DESC
{
    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.pRootSignature"]/*'/>

    public ID3D12RootSignature* pRootSignature;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.VS"]/*'/>

    public D3D12_SHADER_BYTECODE VS;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.PS"]/*'/>

    public D3D12_SHADER_BYTECODE PS;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.DS"]/*'/>

    public D3D12_SHADER_BYTECODE DS;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.HS"]/*'/>

    public D3D12_SHADER_BYTECODE HS;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.GS"]/*'/>

    public D3D12_SHADER_BYTECODE GS;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.StreamOutput"]/*'/>

    public D3D12_STREAM_OUTPUT_DESC StreamOutput;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.BlendState"]/*'/>

    public D3D12_BLEND_DESC BlendState;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.SampleMask"]/*'/>

    public uint SampleMask;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.RasterizerState"]/*'/>

    public D3D12_RASTERIZER_DESC RasterizerState;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.DepthStencilState"]/*'/>

    public D3D12_DEPTH_STENCIL_DESC DepthStencilState;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.InputLayout"]/*'/>

    public D3D12_INPUT_LAYOUT_DESC InputLayout;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.IBStripCutValue"]/*'/>

    public D3D12_INDEX_BUFFER_STRIP_CUT_VALUE IBStripCutValue;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.PrimitiveTopologyType"]/*'/>

    public D3D12_PRIMITIVE_TOPOLOGY_TYPE PrimitiveTopologyType;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.NumRenderTargets"]/*'/>

    public uint NumRenderTargets;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.RTVFormats"]/*'/>

    [NativeTypeName("DXGI_FORMAT[8]")]
    public _RTVFormats_e__FixedBuffer RTVFormats;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.DSVFormat"]/*'/>

    public DXGI_FORMAT DSVFormat;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.SampleDesc"]/*'/>

    public DXGI_SAMPLE_DESC SampleDesc;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.NodeMask"]/*'/>

    public uint NodeMask;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.CachedPSO"]/*'/>

    public D3D12_CACHED_PIPELINE_STATE CachedPSO;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.Flags"]/*'/>

    public D3D12_PIPELINE_STATE_FLAGS Flags;

    /// <include file='_RTVFormats_e__FixedBuffer.xml' path='doc/member[@name="_RTVFormats_e__FixedBuffer"]/*'/>

    [InlineArray(8)]
    public partial struct _RTVFormats_e__FixedBuffer
    {
        public DXGI_FORMAT e0;
    }
}
