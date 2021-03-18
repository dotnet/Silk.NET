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
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_DRAW")]
        IndirectArgumentTypeDraw = 0x0,
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_DRAW_INDEXED")]
        IndirectArgumentTypeDrawIndexed = 0x1,
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH")]
        IndirectArgumentTypeDispatch = 0x2,
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_VERTEX_BUFFER_VIEW")]
        IndirectArgumentTypeVertexBufferView = 0x3,
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_INDEX_BUFFER_VIEW")]
        IndirectArgumentTypeIndexBufferView = 0x4,
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_CONSTANT")]
        IndirectArgumentTypeConstant = 0x5,
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_CONSTANT_BUFFER_VIEW")]
        IndirectArgumentTypeConstantBufferView = 0x6,
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_SHADER_RESOURCE_VIEW")]
        IndirectArgumentTypeShaderResourceView = 0x7,
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_UNORDERED_ACCESS_VIEW")]
        IndirectArgumentTypeUnorderedAccessView = 0x8,
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH_RAYS")]
        IndirectArgumentTypeDispatchRays = 0x9,
        [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH_MESH")]
        IndirectArgumentTypeDispatchMesh = 0xA,
    }
}
