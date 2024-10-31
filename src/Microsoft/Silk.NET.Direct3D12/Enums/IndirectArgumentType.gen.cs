// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE")]
    public enum IndirectArgumentType : int
    {
        [Obsolete("Deprecated in favour of \"Draw\"")]
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_DRAW")]
        IndirectArgumentTypeDraw = 0x0,
        [Obsolete("Deprecated in favour of \"DrawIndexed\"")]
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_DRAW_INDEXED")]
        IndirectArgumentTypeDrawIndexed = 0x1,
        [Obsolete("Deprecated in favour of \"Dispatch\"")]
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH")]
        IndirectArgumentTypeDispatch = 0x2,
        [Obsolete("Deprecated in favour of \"VertexBufferView\"")]
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_VERTEX_BUFFER_VIEW")]
        IndirectArgumentTypeVertexBufferView = 0x3,
        [Obsolete("Deprecated in favour of \"IndexBufferView\"")]
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_INDEX_BUFFER_VIEW")]
        IndirectArgumentTypeIndexBufferView = 0x4,
        [Obsolete("Deprecated in favour of \"Constant\"")]
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_CONSTANT")]
        IndirectArgumentTypeConstant = 0x5,
        [Obsolete("Deprecated in favour of \"ConstantBufferView\"")]
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_CONSTANT_BUFFER_VIEW")]
        IndirectArgumentTypeConstantBufferView = 0x6,
        [Obsolete("Deprecated in favour of \"ShaderResourceView\"")]
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_SHADER_RESOURCE_VIEW")]
        IndirectArgumentTypeShaderResourceView = 0x7,
        [Obsolete("Deprecated in favour of \"UnorderedAccessView\"")]
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_UNORDERED_ACCESS_VIEW")]
        IndirectArgumentTypeUnorderedAccessView = 0x8,
        [Obsolete("Deprecated in favour of \"DispatchRays\"")]
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH_RAYS")]
        IndirectArgumentTypeDispatchRays = 0x9,
        [Obsolete("Deprecated in favour of \"DispatchMesh\"")]
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH_MESH")]
        IndirectArgumentTypeDispatchMesh = 0xA,
        [Obsolete("Deprecated in favour of \"IncrementingConstant\"")]
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_INCREMENTING_CONSTANT")]
        IndirectArgumentTypeIncrementingConstant = 0xB,
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_DRAW")]
        Draw = 0x0,
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_DRAW_INDEXED")]
        DrawIndexed = 0x1,
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH")]
        Dispatch = 0x2,
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_VERTEX_BUFFER_VIEW")]
        VertexBufferView = 0x3,
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_INDEX_BUFFER_VIEW")]
        IndexBufferView = 0x4,
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_CONSTANT")]
        Constant = 0x5,
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_CONSTANT_BUFFER_VIEW")]
        ConstantBufferView = 0x6,
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_SHADER_RESOURCE_VIEW")]
        ShaderResourceView = 0x7,
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_UNORDERED_ACCESS_VIEW")]
        UnorderedAccessView = 0x8,
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH_RAYS")]
        DispatchRays = 0x9,
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH_MESH")]
        DispatchMesh = 0xA,
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_INCREMENTING_CONSTANT")]
        IncrementingConstant = 0xB,
    }
}
