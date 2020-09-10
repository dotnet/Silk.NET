// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_GRAPHICS_PIPELINE_STATE_DESC")]
    public unsafe partial struct GraphicsPipelineStateDesc
    {
        public GraphicsPipelineStateDesc
        (
            ID3D12RootSignature* pRootSignature = default,
            ShaderBytecode vS = default,
            ShaderBytecode pS = default,
            ShaderBytecode dS = default,
            ShaderBytecode hS = default,
            ShaderBytecode gS = default,
            StreamOutputDesc streamOutput = default,
            BlendDesc blendState = default,
            uint sampleMask = default,
            RasterizerDesc rasterizerState = default,
            DepthStencilDesc depthStencilState = default,
            InputLayoutDesc inputLayout = default,
            IndexBufferStripCutValue iBStripCutValue = default,
            PrimitiveTopologyType primitiveTopologyType = default,
            uint numRenderTargets = default,
            Silk.NET.DXGI.Format dSVFormat = default,
            Silk.NET.DXGI.SampleDesc sampleDesc = default,
            uint nodeMask = default,
            CachedPipelineState cachedPSO = default,
            PipelineStateFlags flags = default
        )
        {
            PRootSignature = pRootSignature;
            VS = vS;
            PS = pS;
            DS = dS;
            HS = hS;
            GS = gS;
            StreamOutput = streamOutput;
            BlendState = blendState;
            SampleMask = sampleMask;
            RasterizerState = rasterizerState;
            DepthStencilState = depthStencilState;
            InputLayout = inputLayout;
            IBStripCutValue = iBStripCutValue;
            PrimitiveTopologyType = primitiveTopologyType;
            NumRenderTargets = numRenderTargets;
           RTVFormats_0 = default;
           RTVFormats_1 = default;
           RTVFormats_2 = default;
           RTVFormats_3 = default;
           RTVFormats_4 = default;
           RTVFormats_5 = default;
           RTVFormats_6 = default;
           RTVFormats_7 = default;
            DSVFormat = dSVFormat;
            SampleDesc = sampleDesc;
            NodeMask = nodeMask;
            CachedPSO = cachedPSO;
            Flags = flags;
        }


        [NativeName("Type", "ID3D12RootSignature *")]
        [NativeName("Type.Name", "ID3D12RootSignature *")]
        [NativeName("Name", "pRootSignature")]
        public ID3D12RootSignature* PRootSignature;

        [NativeName("Type", "D3D12_SHADER_BYTECODE")]
        [NativeName("Type.Name", "D3D12_SHADER_BYTECODE")]
        [NativeName("Name", "VS")]
        public ShaderBytecode VS;

        [NativeName("Type", "D3D12_SHADER_BYTECODE")]
        [NativeName("Type.Name", "D3D12_SHADER_BYTECODE")]
        [NativeName("Name", "PS")]
        public ShaderBytecode PS;

        [NativeName("Type", "D3D12_SHADER_BYTECODE")]
        [NativeName("Type.Name", "D3D12_SHADER_BYTECODE")]
        [NativeName("Name", "DS")]
        public ShaderBytecode DS;

        [NativeName("Type", "D3D12_SHADER_BYTECODE")]
        [NativeName("Type.Name", "D3D12_SHADER_BYTECODE")]
        [NativeName("Name", "HS")]
        public ShaderBytecode HS;

        [NativeName("Type", "D3D12_SHADER_BYTECODE")]
        [NativeName("Type.Name", "D3D12_SHADER_BYTECODE")]
        [NativeName("Name", "GS")]
        public ShaderBytecode GS;

        [NativeName("Type", "D3D12_STREAM_OUTPUT_DESC")]
        [NativeName("Type.Name", "D3D12_STREAM_OUTPUT_DESC")]
        [NativeName("Name", "StreamOutput")]
        public StreamOutputDesc StreamOutput;

        [NativeName("Type", "D3D12_BLEND_DESC")]
        [NativeName("Type.Name", "D3D12_BLEND_DESC")]
        [NativeName("Name", "BlendState")]
        public BlendDesc BlendState;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SampleMask")]
        public uint SampleMask;

        [NativeName("Type", "D3D12_RASTERIZER_DESC")]
        [NativeName("Type.Name", "D3D12_RASTERIZER_DESC")]
        [NativeName("Name", "RasterizerState")]
        public RasterizerDesc RasterizerState;

        [NativeName("Type", "D3D12_DEPTH_STENCIL_DESC")]
        [NativeName("Type.Name", "D3D12_DEPTH_STENCIL_DESC")]
        [NativeName("Name", "DepthStencilState")]
        public DepthStencilDesc DepthStencilState;

        [NativeName("Type", "D3D12_INPUT_LAYOUT_DESC")]
        [NativeName("Type.Name", "D3D12_INPUT_LAYOUT_DESC")]
        [NativeName("Name", "InputLayout")]
        public InputLayoutDesc InputLayout;

        [NativeName("Type", "D3D12_INDEX_BUFFER_STRIP_CUT_VALUE")]
        [NativeName("Type.Name", "D3D12_INDEX_BUFFER_STRIP_CUT_VALUE")]
        [NativeName("Name", "IBStripCutValue")]
        public IndexBufferStripCutValue IBStripCutValue;

        [NativeName("Type", "D3D12_PRIMITIVE_TOPOLOGY_TYPE")]
        [NativeName("Type.Name", "D3D12_PRIMITIVE_TOPOLOGY_TYPE")]
        [NativeName("Name", "PrimitiveTopologyType")]
        public PrimitiveTopologyType PrimitiveTopologyType;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumRenderTargets")]
        public uint NumRenderTargets;
        
        [NativeName("Type", "DXGI_FORMAT [8]")]
        [NativeName("Type.Name", "DXGI_FORMAT [8]")]
        [NativeName("Name", "RTVFormats")]
        public Silk.NET.DXGI.Format RTVFormats_0;
        
        [NativeName("Type", "DXGI_FORMAT [8]")]
        [NativeName("Type.Name", "DXGI_FORMAT [8]")]
        [NativeName("Name", "RTVFormats")]
        public Silk.NET.DXGI.Format RTVFormats_1;
        
        [NativeName("Type", "DXGI_FORMAT [8]")]
        [NativeName("Type.Name", "DXGI_FORMAT [8]")]
        [NativeName("Name", "RTVFormats")]
        public Silk.NET.DXGI.Format RTVFormats_2;
        
        [NativeName("Type", "DXGI_FORMAT [8]")]
        [NativeName("Type.Name", "DXGI_FORMAT [8]")]
        [NativeName("Name", "RTVFormats")]
        public Silk.NET.DXGI.Format RTVFormats_3;
        
        [NativeName("Type", "DXGI_FORMAT [8]")]
        [NativeName("Type.Name", "DXGI_FORMAT [8]")]
        [NativeName("Name", "RTVFormats")]
        public Silk.NET.DXGI.Format RTVFormats_4;
        
        [NativeName("Type", "DXGI_FORMAT [8]")]
        [NativeName("Type.Name", "DXGI_FORMAT [8]")]
        [NativeName("Name", "RTVFormats")]
        public Silk.NET.DXGI.Format RTVFormats_5;
        
        [NativeName("Type", "DXGI_FORMAT [8]")]
        [NativeName("Type.Name", "DXGI_FORMAT [8]")]
        [NativeName("Name", "RTVFormats")]
        public Silk.NET.DXGI.Format RTVFormats_6;
        
        [NativeName("Type", "DXGI_FORMAT [8]")]
        [NativeName("Type.Name", "DXGI_FORMAT [8]")]
        [NativeName("Name", "RTVFormats")]
        public Silk.NET.DXGI.Format RTVFormats_7;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "DSVFormat")]
        public Silk.NET.DXGI.Format DSVFormat;

        [NativeName("Type", "DXGI_SAMPLE_DESC")]
        [NativeName("Type.Name", "DXGI_SAMPLE_DESC")]
        [NativeName("Name", "SampleDesc")]
        public Silk.NET.DXGI.SampleDesc SampleDesc;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeMask")]
        public uint NodeMask;

        [NativeName("Type", "D3D12_CACHED_PIPELINE_STATE")]
        [NativeName("Type.Name", "D3D12_CACHED_PIPELINE_STATE")]
        [NativeName("Name", "CachedPSO")]
        public CachedPipelineState CachedPSO;

        [NativeName("Type", "D3D12_PIPELINE_STATE_FLAGS")]
        [NativeName("Type.Name", "D3D12_PIPELINE_STATE_FLAGS")]
        [NativeName("Name", "Flags")]
        public PipelineStateFlags Flags;
    }
}
