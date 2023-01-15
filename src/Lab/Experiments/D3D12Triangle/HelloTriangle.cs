// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12HelloWindow.h in https://github.com/Microsoft/DirectX-Graphics-Samples
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System.Numerics;
using System.Runtime.CompilerServices;
using Silk.NET.Core.Native;
using Silk.NET.Direct3D.Compilers;
using Silk.NET.Direct3D12;
using Silk.NET.DXGI;

namespace D3D12Triangle
{
    public unsafe class HelloTriangle : HelloWindow
    {
        private ID3D12Resource* _vertexBuffer;
        private VertexBufferView _vertexBufferView;
        private D3DCompiler _d3d = D3DCompiler.GetApi();

        public HelloTriangle(string name) : base(name)
        {
        }

        public ref VertexBufferView VertexBufferView => ref _vertexBufferView;

        protected override void CreateAssets()
        {
            CreateBuffers();
            base.CreateAssets();
        }

        protected virtual void CreateBuffers()
        {
            _vertexBuffer = CreateVertexBuffer(out _vertexBufferView);
        }

        protected override unsafe ID3D12PipelineState* CreatePipelineState()
        {
            using ComPtr<ID3D10Blob> pixelShader = null;
            using ComPtr<ID3D10Blob> vertexShader = null;

            var compileFlags = 0u;

#if DEBUG
            // Enable better shader debugging with the graphics debugging tools.
            compileFlags |= (1 << 0) | (1 << 2);
#endif
            fixed (char* fileName = GetAssetFullPath(@"HelloTriangle.hlsl"))
            {
                var entryPoint = 0x00006E69614D5356; // VSMain
                var target = 0x0000305F355F7376; // vs_5_0
                ID3D10Blob* errorMsgs;
                SilkMarshal.ThrowHResult
                (
                    _d3d.CompileFromFile
                    (
                        (char*) fileName, pDefines: null, pInclude: null, (byte*) &entryPoint, (byte*) &target,
                        compileFlags, Flags2: 0, vertexShader.GetAddressOf(), ppErrorMsgs: &errorMsgs
                    )
                );

                entryPoint = 0x00006E69614D5350; // PSMain
                target = 0x0000305F355F7370; // ps_5_0
                SilkMarshal.ThrowHResult
                (
                    _d3d.CompileFromFile
                    (
                        (char*) fileName, pDefines: null, pInclude: null, (byte*) &entryPoint, (byte*) &target,
                        compileFlags, Flags2: 0, pixelShader.GetAddressOf(), ppErrorMsgs: &errorMsgs
                    )
                );
            }

            // Define the vertex input layout.
            const int InputElementDescsCount = 2;

            var semanticName0 = stackalloc ulong[2]
            {
                0x4E4F495449534F50, // POSITION
                0x0000000000000000,
            };

            var semanticName1 = stackalloc ulong[1]
            {
                0x000000524F4C4F43, // COLOR
            };

            var inputElementDescs = stackalloc InputElementDesc[InputElementDescsCount]
            {
                new InputElementDesc
                {
                    SemanticName = (byte*) semanticName0,
                    Format = Format.FormatR32G32B32Float,
                    InputSlotClass = InputClassification.PerVertexData,
                },
                new InputElementDesc
                {
                    SemanticName = (byte*) semanticName1,
                    Format = Format.FormatR32G32B32A32Float,
                    AlignedByteOffset = 12,
                    InputSlotClass = InputClassification.PerVertexData,
                },
            };

            var defaultRenderTargetBlend = new RenderTargetBlendDesc()
            {
                BlendEnable = 0,
                LogicOpEnable = 0,
                SrcBlend = Blend.One,
                DestBlend = Blend.Zero,
                BlendOp = BlendOp.Add,
                SrcBlendAlpha = Blend.One,
                DestBlendAlpha = Blend.Zero,
                BlendOpAlpha = BlendOp.Add,
                LogicOp = LogicOp.Noop,
                RenderTargetWriteMask = (byte) ColorWriteEnable.All
            };

            var defaultStencilOp = new DepthStencilopDesc
            {
                StencilFailOp = StencilOp.Keep,
                StencilDepthFailOp = StencilOp.Keep,
                StencilPassOp = StencilOp.Keep,
                StencilFunc = ComparisonFunc.Always
            };

            // Describe and create the graphics pipeline state object (PSO).
            var psoDesc = new GraphicsPipelineStateDesc
            {
                InputLayout = new InputLayoutDesc
                {
                    PInputElementDescs = inputElementDescs,
                    NumElements = InputElementDescsCount,
                },
                PRootSignature = RootSignature,
                VS = new ShaderBytecode(vertexShader.Get().GetBufferPointer(), vertexShader.Get().GetBufferSize()),
                PS = new ShaderBytecode(pixelShader.Get().GetBufferPointer(), pixelShader.Get().GetBufferSize()),
                RasterizerState = new RasterizerDesc
                {
                    FillMode = FillMode.Solid,
                    CullMode = CullMode.Back,
                    FrontCounterClockwise = 0,
                    DepthBias = D3D12.DefaultDepthBias,
                    DepthBiasClamp = 0,
                    SlopeScaledDepthBias = 0,
                    DepthClipEnable = 1,
                    MultisampleEnable = 0,
                    AntialiasedLineEnable = 0,
                    ForcedSampleCount = 0,
                    ConservativeRaster = ConservativeRasterizationMode.Off,
                },
                BlendState = new BlendDesc
                {
                    AlphaToCoverageEnable = 0,
                    IndependentBlendEnable = 0,
                    RenderTarget = new BlendDesc.RenderTargetBuffer()
                    {
                        [0] = defaultRenderTargetBlend,
                        [1] = defaultRenderTargetBlend,
                        [2] = defaultRenderTargetBlend,
                        [3] = defaultRenderTargetBlend,
                        [4] = defaultRenderTargetBlend,
                        [5] = defaultRenderTargetBlend,
                        [6] = defaultRenderTargetBlend,
                        [7] = defaultRenderTargetBlend
                    }
                },
                DepthStencilState = new DepthStencilDesc
                {
                    DepthEnable = 1,
                    DepthWriteMask = DepthWriteMask.All,
                    DepthFunc = ComparisonFunc.Less,
                    StencilEnable = 0,
                    StencilReadMask = D3D12.DefaultStencilReadMask,
                    StencilWriteMask = D3D12.DefaultStencilWriteMask,
                    FrontFace = defaultStencilOp,
                    BackFace = defaultStencilOp
                },
                SampleMask = uint.MaxValue,
                PrimitiveTopologyType = PrimitiveTopologyType.Triangle,
                NumRenderTargets = 1,
                SampleDesc = new SampleDesc(count: 1, quality: 0),
            };
            psoDesc.DepthStencilState.DepthEnable = 0;
            psoDesc.RTVFormats[0] = Format.FormatR8G8B8A8Unorm;

            ID3D12PipelineState* pipelineState;

            var iid = ID3D12PipelineState.Guid;
            SilkMarshal.ThrowHResult(D3DDevice->CreateGraphicsPipelineState(&psoDesc, &iid, (void**) &pipelineState));

            return pipelineState;
        }

        protected override unsafe ID3D12RootSignature* CreateRootSignature()
        {
            using ComPtr<ID3D10Blob> signature = null;
            using ComPtr<ID3D10Blob> error = null;

            var rootSignatureDesc = new RootSignatureDesc
            {
                Flags = RootSignatureFlags.AllowInputAssemblerInputLayout
            };

            SilkMarshal.ThrowHResult
            (
                D3D12.SerializeRootSignature
                (
                    &rootSignatureDesc, D3DRootSignatureVersion.Version1, signature.GetAddressOf(),
                    error.GetAddressOf()
                )
            );

            ID3D12RootSignature* rootSignature;

            var iid = ID3D12RootSignature.Guid;
            SilkMarshal.ThrowHResult
            (
                D3DDevice->CreateRootSignature
                (
                    nodeMask: 0, signature.Get().GetBufferPointer(), signature.Get().GetBufferSize(), &iid,
                    (void**) &rootSignature
                )
            );

            return rootSignature;
        }

        protected virtual ID3D12Resource* CreateVertexBuffer(out VertexBufferView vertexBufferView)
        {
            // Define the geometry for a triangle.
            const int TriangleVerticesCount = 3;
            var triangleVertices = stackalloc Vertex[TriangleVerticesCount]
            {
                new Vertex
                {
                    Position = new Vector3(0.0f, 0.5f, 0.0f),
                    Color = new Vector4(1.0f, 0.0f, 0.0f, 1.0f)
                },
                new Vertex
                {
                    Position = new Vector3(0.5f, -0.5f, 0.0f),
                    Color = new Vector4(0.0f, 1.0f, 0.0f, 1.0f)
                },
                new Vertex
                {
                    Position = new Vector3(-0.5f, -0.5f, 0.0f),
                    Color = new Vector4(0.0f, 0.0f, 1.0f, 1.0f)
                },
            };

            var vertexBufferSize = (uint) sizeof(Vertex) * TriangleVerticesCount;

            // Note: using upload heaps to transfer static data like vert buffers is not
            // recommended. Every time the GPU needs it, the upload heap will be marshalled
            // over. Please read up on Default Heap usage. An upload heap is used here for
            // code simplicity and because there are very few verts to actually transfer.
            ID3D12Resource* vertexBuffer;

            var heapProperties = new HeapProperties(HeapType.Upload);
            var bufferDesc = new ResourceDesc
            (
                ResourceDimension.Buffer, 0, vertexBufferSize, 1, 1, 1, Format.FormatUnknown,
                new SampleDesc(1, 0),
                TextureLayout.LayoutRowMajor, ResourceFlags.None
            );

            var iid = ID3D12Resource.Guid;
            SilkMarshal.ThrowHResult
            (
                D3DDevice->CreateCommittedResource
                (
                    &heapProperties,
                    HeapFlags.None,
                    &bufferDesc,
                    ResourceStates.GenericRead,
                    pOptimizedClearValue: null,
                    &iid,
                    (void**) &vertexBuffer
                )
            );

            // Copy the triangle data to the vertex buffer.
            var readRange = new Range();

            byte* pVertexDataBegin;
            SilkMarshal.ThrowHResult(vertexBuffer->Map(Subresource: 0, &readRange, (void**) &pVertexDataBegin));
            Unsafe.CopyBlock(pVertexDataBegin, triangleVertices, vertexBufferSize);
            vertexBuffer->Unmap(0, null);

            // Initialize the vertex buffer view.
            vertexBufferView.BufferLocation = vertexBuffer->GetGPUVirtualAddress();
            vertexBufferView.StrideInBytes = (uint) sizeof(Vertex);
            vertexBufferView.SizeInBytes = vertexBufferSize;

            return vertexBuffer;
        }

        protected override void DestroyAssets()
        {
            DestroyBuffers();
        }

        protected virtual void DestroyBuffers()
        {
            DestroyVertexBuffer();

            void DestroyVertexBuffer()
            {
                var vertexBuffer = _vertexBuffer;

                if (vertexBuffer != null)
                {
                    _vertexBuffer = null;
                    _ = vertexBuffer->Release();
                }
            }
        }

        protected override void Draw()
        {
            GraphicsCommandList->IASetPrimitiveTopology(D3DPrimitiveTopology.D3DPrimitiveTopologyTrianglelist);

            fixed (VertexBufferView* vertexBufferView = &_vertexBufferView)
            {
                GraphicsCommandList->IASetVertexBuffers(StartSlot: 0, 1, vertexBufferView);
            }

            GraphicsCommandList->DrawInstanced
                (VertexCountPerInstance: 3, InstanceCount: 1, StartVertexLocation: 0, StartInstanceLocation: 0);
        }

        public struct Vertex
        {
            public Vector3 Position;

            public Vector4 Color;
        }
    }
}
