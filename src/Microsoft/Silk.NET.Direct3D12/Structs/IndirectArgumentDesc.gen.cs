// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "D3D12_INDIRECT_ARGUMENT_DESC")]
    public unsafe partial struct IndirectArgumentDesc
    {
        public IndirectArgumentDesc
        (
            IndirectArgumentType? type = null,
            IndirectArgumentDescUnion? anonymous = null,
            IndirectArgumentDescUnionVertexBuffer? vertexBuffer = null,
            IndirectArgumentDescUnionConstant? constant = null,
            IndirectArgumentDescUnionConstantBufferView? constantBufferView = null,
            IndirectArgumentDescUnionShaderResourceView? shaderResourceView = null,
            IndirectArgumentDescUnionUnorderedAccessView? unorderedAccessView = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

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
        }


        [NativeName("Type", "D3D12_INDIRECT_ARGUMENT_TYPE")]
        [NativeName("Type.Name", "D3D12_INDIRECT_ARGUMENT_TYPE")]
        [NativeName("Name", "Type")]
        public IndirectArgumentType Type;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12_L3951_C5")]
        [NativeName("Name", "anonymous1")]
        public IndirectArgumentDescUnion Anonymous;
        public IndirectArgumentDescUnionVertexBuffer VertexBuffer
        {
            get => Anonymous.VertexBuffer;
            set => Anonymous.VertexBuffer = value;
        }

        public IndirectArgumentDescUnionConstant Constant
        {
            get => Anonymous.Constant;
            set => Anonymous.Constant = value;
        }

        public IndirectArgumentDescUnionConstantBufferView ConstantBufferView
        {
            get => Anonymous.ConstantBufferView;
            set => Anonymous.ConstantBufferView = value;
        }

        public IndirectArgumentDescUnionShaderResourceView ShaderResourceView
        {
            get => Anonymous.ShaderResourceView;
            set => Anonymous.ShaderResourceView = value;
        }

        public IndirectArgumentDescUnionUnorderedAccessView UnorderedAccessView
        {
            get => Anonymous.UnorderedAccessView;
            set => Anonymous.UnorderedAccessView = value;
        }

    }
}
