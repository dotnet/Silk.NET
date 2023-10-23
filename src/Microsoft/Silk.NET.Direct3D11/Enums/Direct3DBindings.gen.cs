// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "Direct3DBindings")]
    public enum Direct3DBindings : uint
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"VertexBuffer\"")]
        [NativeName("Name", "Direct3DBindings_VertexBuffer")]
        Direct3DBindingsVertexBuffer = 0x1,
        [Obsolete("Deprecated in favour of \"IndexBuffer\"")]
        [NativeName("Name", "Direct3DBindings_IndexBuffer")]
        Direct3DBindingsIndexBuffer = 0x2,
        [Obsolete("Deprecated in favour of \"ConstantBuffer\"")]
        [NativeName("Name", "Direct3DBindings_ConstantBuffer")]
        Direct3DBindingsConstantBuffer = 0x4,
        [Obsolete("Deprecated in favour of \"ShaderResource\"")]
        [NativeName("Name", "Direct3DBindings_ShaderResource")]
        Direct3DBindingsShaderResource = 0x8,
        [Obsolete("Deprecated in favour of \"StreamOutput\"")]
        [NativeName("Name", "Direct3DBindings_StreamOutput")]
        Direct3DBindingsStreamOutput = 0x10,
        [Obsolete("Deprecated in favour of \"RenderTarget\"")]
        [NativeName("Name", "Direct3DBindings_RenderTarget")]
        Direct3DBindingsRenderTarget = 0x20,
        [Obsolete("Deprecated in favour of \"DepthStencil\"")]
        [NativeName("Name", "Direct3DBindings_DepthStencil")]
        Direct3DBindingsDepthStencil = 0x40,
        [Obsolete("Deprecated in favour of \"UnorderedAccess\"")]
        [NativeName("Name", "Direct3DBindings_UnorderedAccess")]
        Direct3DBindingsUnorderedAccess = 0x80,
        [Obsolete("Deprecated in favour of \"Decoder\"")]
        [NativeName("Name", "Direct3DBindings_Decoder")]
        Direct3DBindingsDecoder = 0x200,
        [Obsolete("Deprecated in favour of \"VideoEncoder\"")]
        [NativeName("Name", "Direct3DBindings_VideoEncoder")]
        Direct3DBindingsVideoEncoder = 0x400,
        [NativeName("Name", "Direct3DBindings_VertexBuffer")]
        VertexBuffer = 0x1,
        [NativeName("Name", "Direct3DBindings_IndexBuffer")]
        IndexBuffer = 0x2,
        [NativeName("Name", "Direct3DBindings_ConstantBuffer")]
        ConstantBuffer = 0x4,
        [NativeName("Name", "Direct3DBindings_ShaderResource")]
        ShaderResource = 0x8,
        [NativeName("Name", "Direct3DBindings_StreamOutput")]
        StreamOutput = 0x10,
        [NativeName("Name", "Direct3DBindings_RenderTarget")]
        RenderTarget = 0x20,
        [NativeName("Name", "Direct3DBindings_DepthStencil")]
        DepthStencil = 0x40,
        [NativeName("Name", "Direct3DBindings_UnorderedAccess")]
        UnorderedAccess = 0x80,
        [NativeName("Name", "Direct3DBindings_Decoder")]
        Decoder = 0x200,
        [NativeName("Name", "Direct3DBindings_VideoEncoder")]
        VideoEncoder = 0x400,
    }
}
