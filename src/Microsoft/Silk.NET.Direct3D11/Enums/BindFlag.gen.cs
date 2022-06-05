// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_BIND_FLAG")]
    public enum BindFlag : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"VertexBuffer\"")]
        [NativeName("Name", "D3D11_BIND_VERTEX_BUFFER")]
        BindVertexBuffer = 0x1,
        [Obsolete("Deprecated in favour of \"IndexBuffer\"")]
        [NativeName("Name", "D3D11_BIND_INDEX_BUFFER")]
        BindIndexBuffer = 0x2,
        [Obsolete("Deprecated in favour of \"ConstantBuffer\"")]
        [NativeName("Name", "D3D11_BIND_CONSTANT_BUFFER")]
        BindConstantBuffer = 0x4,
        [Obsolete("Deprecated in favour of \"ShaderResource\"")]
        [NativeName("Name", "D3D11_BIND_SHADER_RESOURCE")]
        BindShaderResource = 0x8,
        [Obsolete("Deprecated in favour of \"StreamOutput\"")]
        [NativeName("Name", "D3D11_BIND_STREAM_OUTPUT")]
        BindStreamOutput = 0x10,
        [Obsolete("Deprecated in favour of \"RenderTarget\"")]
        [NativeName("Name", "D3D11_BIND_RENDER_TARGET")]
        BindRenderTarget = 0x20,
        [Obsolete("Deprecated in favour of \"DepthStencil\"")]
        [NativeName("Name", "D3D11_BIND_DEPTH_STENCIL")]
        BindDepthStencil = 0x40,
        [Obsolete("Deprecated in favour of \"UnorderedAccess\"")]
        [NativeName("Name", "D3D11_BIND_UNORDERED_ACCESS")]
        BindUnorderedAccess = 0x80,
        [Obsolete("Deprecated in favour of \"Decoder\"")]
        [NativeName("Name", "D3D11_BIND_DECODER")]
        BindDecoder = 0x200,
        [Obsolete("Deprecated in favour of \"VideoEncoder\"")]
        [NativeName("Name", "D3D11_BIND_VIDEO_ENCODER")]
        BindVideoEncoder = 0x400,
        [NativeName("Name", "D3D11_BIND_VERTEX_BUFFER")]
        VertexBuffer = 0x1,
        [NativeName("Name", "D3D11_BIND_INDEX_BUFFER")]
        IndexBuffer = 0x2,
        [NativeName("Name", "D3D11_BIND_CONSTANT_BUFFER")]
        ConstantBuffer = 0x4,
        [NativeName("Name", "D3D11_BIND_SHADER_RESOURCE")]
        ShaderResource = 0x8,
        [NativeName("Name", "D3D11_BIND_STREAM_OUTPUT")]
        StreamOutput = 0x10,
        [NativeName("Name", "D3D11_BIND_RENDER_TARGET")]
        RenderTarget = 0x20,
        [NativeName("Name", "D3D11_BIND_DEPTH_STENCIL")]
        DepthStencil = 0x40,
        [NativeName("Name", "D3D11_BIND_UNORDERED_ACCESS")]
        UnorderedAccess = 0x80,
        [NativeName("Name", "D3D11_BIND_DECODER")]
        Decoder = 0x200,
        [NativeName("Name", "D3D11_BIND_VIDEO_ENCODER")]
        VideoEncoder = 0x400,
    }
}
