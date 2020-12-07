// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_BIND_FLAG")]
    public enum BindFlag
    {
        [NativeName("Name", "D3D11_BIND_VERTEX_BUFFER")]
        BindVertexBuffer = 0x1,
        [NativeName("Name", "D3D11_BIND_INDEX_BUFFER")]
        BindIndexBuffer = 0x2,
        [NativeName("Name", "D3D11_BIND_CONSTANT_BUFFER")]
        BindConstantBuffer = 0x4,
        [NativeName("Name", "D3D11_BIND_SHADER_RESOURCE")]
        BindShaderResource = 0x8,
        [NativeName("Name", "D3D11_BIND_STREAM_OUTPUT")]
        BindStreamOutput = 0x10,
        [NativeName("Name", "D3D11_BIND_RENDER_TARGET")]
        BindRenderTarget = 0x20,
        [NativeName("Name", "D3D11_BIND_DEPTH_STENCIL")]
        BindDepthStencil = 0x40,
        [NativeName("Name", "D3D11_BIND_UNORDERED_ACCESS")]
        BindUnorderedAccess = 0x80,
        [NativeName("Name", "D3D11_BIND_DECODER")]
        BindDecoder = 0x200,
        [NativeName("Name", "D3D11_BIND_VIDEO_ENCODER")]
        BindVideoEncoder = 0x400,
    }
}
