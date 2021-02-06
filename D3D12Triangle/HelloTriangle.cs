// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12HelloWindow.h in https://github.com/Microsoft/DirectX-Graphics-Samples
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System.Numerics;
using System.Runtime.CompilerServices;

namespace D3D12Triangle
{
    public unsafe class HelloTriangle12 : HelloWindow12
    {
        private ID3D12Resource* _vertexBuffer;
        private D3D12_VERTEX_BUFFER_VIEW _vertexBufferView;

        public HelloTriangle12(string name) : base(name)
        {
        }

        public ref D3D12_VERTEX_BUFFER_VIEW VertexBufferView => ref _vertexBufferView;

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
            using ComPtr<ID3DBlob> pixelShader = null;
            using ComPtr<ID3DBlob> vertexShader = null;

            var compileFlags = 0u;

#if DEBUG
            // Enable better shader debugging with the graphics debugging tools.
            compileFlags |= D3DCOMPILE_DEBUG | D3DCOMPILE_SKIP_OPTIMIZATION;
#endif
            fixed (char* fileName = GetAssetFullPath(@"D3D12\Assets\Shaders\HelloTriangle.hlsl"))
            {
                var entryPoint = 0x00006E69614D5356;    // VSMain
                var target = 0x0000305F355F7376;        // vs_5_0
                ThrowIfFailed(nameof(D3DCompileFromFile), D3DCompileFromFile((ushort*)fileName, pDefines: null, pInclude: null, (sbyte*)&entryPoint, (sbyte*)&target, compileFlags, Flags2: 0, vertexShader.GetAddressOf(), ppErrorMsgs: null));

                entryPoint = 0x00006E69614D5350;        // PSMain
                target = 0x0000305F355F7370;            // ps_5_0
                ThrowIfFailed(nameof(D3DCompileFromFile), D3DCompileFromFile((ushort*)fileName, pDefines: null, pInclude: null, (sbyte*)&entryPoint, (sbyte*)&target, compileFlags, Flags2: 0, pixelShader.GetAddressOf(), ppErrorMsgs: null));
            }

            // Define the vertex input layout.
            const int InputElementDescsCount = 2;

            var semanticName0 = stackalloc ulong[2] {
                0x4E4F495449534F50,     // POSITION
                0x0000000000000000,
            };

            var semanticName1 = stackalloc ulong[1] {
                0x000000524F4C4F43,     // COLOR
            };

            var inputElementDescs = stackalloc D3D12_INPUT_ELEMENT_DESC[InputElementDescsCount] {
                new D3D12_INPUT_ELEMENT_DESC {
                    SemanticName = (sbyte*)semanticName0,
                    Format = DXGI_FORMAT_R32G32B32_FLOAT,
                    InputSlotClass = D3D12_INPUT_CLASSIFICATION_PER_VERTEX_DATA,
                },
                new D3D12_INPUT_ELEMENT_DESC {
                    SemanticName = (sbyte*)semanticName1,
                    Format = DXGI_FORMAT_R32G32B32A32_FLOAT,
                    AlignedByteOffset = 12,
                    InputSlotClass = D3D12_INPUT_CLASSIFICATION_PER_VERTEX_DATA,
                },
            };

            // Describe and create the graphics pipeline state object (PSO).
            var psoDesc = new D3D12_GRAPHICS_PIPELINE_STATE_DESC {
                InputLayout = new D3D12_INPUT_LAYOUT_DESC {
                    pInputElementDescs = inputElementDescs,
                    NumElements = InputElementDescsCount,
                },
                pRootSignature = RootSignature,
                VS = new D3D12_SHADER_BYTECODE(vertexShader),
                PS = new D3D12_SHADER_BYTECODE(pixelShader),
                RasterizerState = D3D12_RASTERIZER_DESC.DEFAULT,
                BlendState = D3D12_BLEND_DESC.DEFAULT,
                DepthStencilState = D3D12_DEPTH_STENCIL_DESC.DEFAULT,
                SampleMask = uint.MaxValue,
                PrimitiveTopologyType = D3D12_PRIMITIVE_TOPOLOGY_TYPE_TRIANGLE,
                NumRenderTargets = 1,
                SampleDesc = new DXGI_SAMPLE_DESC(count: 1, quality: 0),
            };
            psoDesc.DepthStencilState.DepthEnable = FALSE;
            psoDesc.RTVFormats[0] = DXGI_FORMAT_R8G8B8A8_UNORM;

            ID3D12PipelineState* pipelineState;

            var iid = IID_ID3D12PipelineState;
            ThrowIfFailed(nameof(ID3D12Device.CreateGraphicsPipelineState), D3DDevice->CreateGraphicsPipelineState(&psoDesc, &iid, (void**)&pipelineState));

            return pipelineState;
        }

        protected override unsafe ID3D12RootSignature* CreateRootSignature()
        {
            using ComPtr<ID3DBlob> signature = null;
            using ComPtr<ID3DBlob> error = null;

            var rootSignatureDesc = new D3D12_ROOT_SIGNATURE_DESC {
                Flags = D3D12_ROOT_SIGNATURE_FLAG_ALLOW_INPUT_ASSEMBLER_INPUT_LAYOUT
            };

            ThrowIfFailed(nameof(D3D12SerializeRootSignature), D3D12SerializeRootSignature(&rootSignatureDesc, D3D_ROOT_SIGNATURE_VERSION_1, signature.GetAddressOf(), error.GetAddressOf()));

            ID3D12RootSignature* rootSignature;

            var iid = IID_ID3D12RootSignature;
            ThrowIfFailed(nameof(ID3D12Device.CreateRootSignature), D3DDevice->CreateRootSignature(nodeMask: 0, signature.Get()->GetBufferPointer(), signature.Get()->GetBufferSize(), &iid, (void**)&rootSignature));

            return rootSignature;
        }

        protected virtual ID3D12Resource* CreateVertexBuffer(out D3D12_VERTEX_BUFFER_VIEW vertexBufferView)
        {
            // Define the geometry for a triangle.
            const int TriangleVerticesCount = 3;
            var triangleVertices = stackalloc Vertex[TriangleVerticesCount] {
                new Vertex {
                    Position = new Vector3(0.0f, 0.25f * AspectRatio, 0.0f),
                    Color = new Vector4(1.0f, 0.0f, 0.0f, 1.0f)
                },
                new Vertex {
                    Position = new Vector3(0.25f, -0.25f * AspectRatio, 0.0f),
                    Color = new Vector4(0.0f, 1.0f, 0.0f, 1.0f)
                },
                new Vertex {
                    Position = new Vector3(-0.25f, -0.25f * AspectRatio, 0.0f),
                    Color = new Vector4(0.0f, 0.0f, 1.0f, 1.0f)
                },
            };

            var vertexBufferSize = (uint)sizeof(Vertex) * TriangleVerticesCount;

            // Note: using upload heaps to transfer static data like vert buffers is not
            // recommended. Every time the GPU needs it, the upload heap will be marshalled
            // over. Please read up on Default Heap usage. An upload heap is used here for
            // code simplicity and because there are very few verts to actually transfer.
            ID3D12Resource* vertexBuffer;

            var heapProperties = new D3D12_HEAP_PROPERTIES(D3D12_HEAP_TYPE_UPLOAD);
            var bufferDesc = D3D12_RESOURCE_DESC.Buffer(vertexBufferSize);

            var iid = IID_ID3D12Resource;
            ThrowIfFailed(nameof(ID3D12Device.CreateCommittedResource), D3DDevice->CreateCommittedResource(
                &heapProperties,
                D3D12_HEAP_FLAG_NONE,
                &bufferDesc,
                D3D12_RESOURCE_STATE_GENERIC_READ,
                pOptimizedClearValue: null,
                &iid,
                (void**)&vertexBuffer
            ));

            // Copy the triangle data to the vertex buffer.
            var readRange = new D3D12_RANGE();

            byte* pVertexDataBegin;
            ThrowIfFailed(nameof(ID3D12Resource.Map), vertexBuffer->Map(Subresource: 0, &readRange, (void**)&pVertexDataBegin));
            Unsafe.CopyBlock(pVertexDataBegin, triangleVertices, vertexBufferSize);
            vertexBuffer->Unmap(0, null);

            // Initialize the vertex buffer view.
            vertexBufferView.BufferLocation = vertexBuffer->GetGPUVirtualAddress();
            vertexBufferView.StrideInBytes = (uint)sizeof(Vertex);
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
            GraphicsCommandList->IASetPrimitiveTopology(D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST);

            fixed (D3D12_VERTEX_BUFFER_VIEW* vertexBufferView = &_vertexBufferView)
            {
                GraphicsCommandList->IASetVertexBuffers(StartSlot: 0, 1, vertexBufferView);
            }

            GraphicsCommandList->DrawInstanced(VertexCountPerInstance: 3, InstanceCount: 1, StartVertexLocation: 0, StartInstanceLocation: 0);
        }

        public struct Vertex
        {
            public Vector3 Position;

            public Vector4 Color;
        }
    }
}
