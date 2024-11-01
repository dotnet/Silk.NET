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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12_L4527_C5")]
    public unsafe partial struct IndirectArgumentDescUnion
    {
        public IndirectArgumentDescUnion
        (
            IndirectArgumentDescUnionVertexBuffer? vertexBuffer = null,
            IndirectArgumentDescUnionConstant? constant = null,
            IndirectArgumentDescUnionConstantBufferView? constantBufferView = null,
            IndirectArgumentDescUnionShaderResourceView? shaderResourceView = null,
            IndirectArgumentDescUnionUnorderedAccessView? unorderedAccessView = null,
            IndirectArgumentDescUnionIncrementingConstant? incrementingConstant = null
        ) : this()
        {
            if (vertexBuffer is not null)
            {
                VertexBuffer = vertexBuffer.Value;
            }

            if (constant is not null)
            {
                Constant = constant.Value;
            }

            if (constantBufferView is not null)
            {
                ConstantBufferView = constantBufferView.Value;
            }

            if (shaderResourceView is not null)
            {
                ShaderResourceView = shaderResourceView.Value;
            }

            if (unorderedAccessView is not null)
            {
                UnorderedAccessView = unorderedAccessView.Value;
            }

            if (incrementingConstant is not null)
            {
                IncrementingConstant = incrementingConstant.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "struct (unnamed struct at d3d12.h:4529:9)")]
        [NativeName("Type.Name", "struct (unnamed struct at d3d12.h:4529:9)")]
        [NativeName("Name", "VertexBuffer")]
        public IndirectArgumentDescUnionVertexBuffer VertexBuffer;

        [FieldOffset(0)]
        [NativeName("Type", "struct (unnamed struct at d3d12.h:4533:9)")]
        [NativeName("Type.Name", "struct (unnamed struct at d3d12.h:4533:9)")]
        [NativeName("Name", "Constant")]
        public IndirectArgumentDescUnionConstant Constant;

        [FieldOffset(0)]
        [NativeName("Type", "struct (unnamed struct at d3d12.h:4539:9)")]
        [NativeName("Type.Name", "struct (unnamed struct at d3d12.h:4539:9)")]
        [NativeName("Name", "ConstantBufferView")]
        public IndirectArgumentDescUnionConstantBufferView ConstantBufferView;

        [FieldOffset(0)]
        [NativeName("Type", "struct (unnamed struct at d3d12.h:4543:9)")]
        [NativeName("Type.Name", "struct (unnamed struct at d3d12.h:4543:9)")]
        [NativeName("Name", "ShaderResourceView")]
        public IndirectArgumentDescUnionShaderResourceView ShaderResourceView;

        [FieldOffset(0)]
        [NativeName("Type", "struct (unnamed struct at d3d12.h:4547:9)")]
        [NativeName("Type.Name", "struct (unnamed struct at d3d12.h:4547:9)")]
        [NativeName("Name", "UnorderedAccessView")]
        public IndirectArgumentDescUnionUnorderedAccessView UnorderedAccessView;

        [FieldOffset(0)]
        [NativeName("Type", "struct (unnamed struct at d3d12.h:4551:9)")]
        [NativeName("Type.Name", "struct (unnamed struct at d3d12.h:4551:9)")]
        [NativeName("Name", "IncrementingConstant")]
        public IndirectArgumentDescUnionIncrementingConstant IncrementingConstant;
    }
}
