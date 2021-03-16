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
    [NativeName("Name", "D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC")]
    public unsafe partial struct RaytracingGeometryTrianglesDesc
    {
        public RaytracingGeometryTrianglesDesc
        (
            ulong? transform3x4 = null,
            Silk.NET.DXGI.Format? indexFormat = null,
            Silk.NET.DXGI.Format? vertexFormat = null,
            uint? indexCount = null,
            uint? vertexCount = null,
            ulong? indexBuffer = null,
            GpuVirtualAddressAndStride? vertexBuffer = null
        ) : this()
        {
            if (transform3x4 is not null)
            {
                Transform3x4 = transform3x4.Value;
            }

            if (indexFormat is not null)
            {
                IndexFormat = indexFormat.Value;
            }

            if (vertexFormat is not null)
            {
                VertexFormat = vertexFormat.Value;
            }

            if (indexCount is not null)
            {
                IndexCount = indexCount.Value;
            }

            if (vertexCount is not null)
            {
                VertexCount = vertexCount.Value;
            }

            if (indexBuffer is not null)
            {
                IndexBuffer = indexBuffer.Value;
            }

            if (vertexBuffer is not null)
            {
                VertexBuffer = vertexBuffer.Value;
            }
        }


        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "Transform3x4")]
        public ulong Transform3x4;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "IndexFormat")]
        public Silk.NET.DXGI.Format IndexFormat;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "VertexFormat")]
        public Silk.NET.DXGI.Format VertexFormat;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "IndexCount")]
        public uint IndexCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "VertexCount")]
        public uint VertexCount;

        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "IndexBuffer")]
        public ulong IndexBuffer;

        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE")]
        [NativeName("Name", "VertexBuffer")]
        public GpuVirtualAddressAndStride VertexBuffer;
    }
}
