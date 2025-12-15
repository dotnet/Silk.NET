// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
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
            ID3D12RootSignature* pRootSignature = null,
            ShaderBytecode? vS = null,
            ShaderBytecode? pS = null,
            ShaderBytecode? dS = null,
            ShaderBytecode? hS = null,
            ShaderBytecode? gS = null,
            StreamOutputDesc? streamOutput = null,
            BlendDesc? blendState = null,
            uint? sampleMask = null,
            RasterizerDesc? rasterizerState = null,
            DepthStencilDesc? depthStencilState = null,
            InputLayoutDesc? inputLayout = null,
            IndexBufferStripCutValue? iBStripCutValue = null,
            PrimitiveTopologyType? primitiveTopologyType = null,
            uint? numRenderTargets = null,
            Silk.NET.DXGI.Format? dSVFormat = null,
            Silk.NET.DXGI.SampleDesc? sampleDesc = null,
            uint? nodeMask = null,
            CachedPipelineState? cachedPSO = null,
            PipelineStateFlags? flags = null
        ) : this()
        {
            if (pRootSignature is not null)
            {
                PRootSignature = pRootSignature;
            }

            if (vS is not null)
            {
                VS = vS.Value;
            }

            if (pS is not null)
            {
                PS = pS.Value;
            }

            if (dS is not null)
            {
                DS = dS.Value;
            }

            if (hS is not null)
            {
                HS = hS.Value;
            }

            if (gS is not null)
            {
                GS = gS.Value;
            }

            if (streamOutput is not null)
            {
                StreamOutput = streamOutput.Value;
            }

            if (blendState is not null)
            {
                BlendState = blendState.Value;
            }

            if (sampleMask is not null)
            {
                SampleMask = sampleMask.Value;
            }

            if (rasterizerState is not null)
            {
                RasterizerState = rasterizerState.Value;
            }

            if (depthStencilState is not null)
            {
                DepthStencilState = depthStencilState.Value;
            }

            if (inputLayout is not null)
            {
                InputLayout = inputLayout.Value;
            }

            if (iBStripCutValue is not null)
            {
                IBStripCutValue = iBStripCutValue.Value;
            }

            if (primitiveTopologyType is not null)
            {
                PrimitiveTopologyType = primitiveTopologyType.Value;
            }

            if (numRenderTargets is not null)
            {
                NumRenderTargets = numRenderTargets.Value;
            }

            if (dSVFormat is not null)
            {
                DSVFormat = dSVFormat.Value;
            }

            if (sampleDesc is not null)
            {
                SampleDesc = sampleDesc.Value;
            }

            if (nodeMask is not null)
            {
                NodeMask = nodeMask.Value;
            }

            if (cachedPSO is not null)
            {
                CachedPSO = cachedPSO.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
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
        
        [NativeName("Type", "DXGI_FORMAT[8]")]
        [NativeName("Type.Name", "DXGI_FORMAT[8]")]
        [NativeName("Name", "RTVFormats")]
        public RTVFormatsBuffer RTVFormats;

        public struct RTVFormatsBuffer
        {
            public Silk.NET.DXGI.Format Element0;
            public Silk.NET.DXGI.Format Element1;
            public Silk.NET.DXGI.Format Element2;
            public Silk.NET.DXGI.Format Element3;
            public Silk.NET.DXGI.Format Element4;
            public Silk.NET.DXGI.Format Element5;
            public Silk.NET.DXGI.Format Element6;
            public Silk.NET.DXGI.Format Element7;
            public ref Silk.NET.DXGI.Format this[int index]
            {
                get
                {
                    if (index > 7 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (Silk.NET.DXGI.Format* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<Silk.NET.DXGI.Format> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 8);
#endif
        }


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
