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
            IndirectArgumentDescUnionUnorderedAccessView? unorderedAccessView = null,
            IndirectArgumentDescUnionIncrementingConstant? incrementingConstant = null
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

            if (incrementingConstant is not null)
            {
                IncrementingConstant = incrementingConstant.Value;
            }
        }


        [NativeName("Type", "D3D12_INDIRECT_ARGUMENT_TYPE")]
        [NativeName("Type.Name", "D3D12_INDIRECT_ARGUMENT_TYPE")]
        [NativeName("Name", "Type")]
        public IndirectArgumentType Type;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12_L4527_C5")]
        [NativeName("Name", "anonymous1")]
        public IndirectArgumentDescUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref IndirectArgumentDescUnionVertexBuffer VertexBuffer
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].VertexBuffer;
        }
#else
        public IndirectArgumentDescUnionVertexBuffer VertexBuffer
        {
            get => Anonymous.VertexBuffer;
            set => Anonymous.VertexBuffer = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref IndirectArgumentDescUnionConstant Constant
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Constant;
        }
#else
        public IndirectArgumentDescUnionConstant Constant
        {
            get => Anonymous.Constant;
            set => Anonymous.Constant = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref IndirectArgumentDescUnionConstantBufferView ConstantBufferView
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].ConstantBufferView;
        }
#else
        public IndirectArgumentDescUnionConstantBufferView ConstantBufferView
        {
            get => Anonymous.ConstantBufferView;
            set => Anonymous.ConstantBufferView = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref IndirectArgumentDescUnionShaderResourceView ShaderResourceView
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].ShaderResourceView;
        }
#else
        public IndirectArgumentDescUnionShaderResourceView ShaderResourceView
        {
            get => Anonymous.ShaderResourceView;
            set => Anonymous.ShaderResourceView = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref IndirectArgumentDescUnionUnorderedAccessView UnorderedAccessView
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].UnorderedAccessView;
        }
#else
        public IndirectArgumentDescUnionUnorderedAccessView UnorderedAccessView
        {
            get => Anonymous.UnorderedAccessView;
            set => Anonymous.UnorderedAccessView = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref IndirectArgumentDescUnionIncrementingConstant IncrementingConstant
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].IncrementingConstant;
        }
#else
        public IndirectArgumentDescUnionIncrementingConstant IncrementingConstant
        {
            get => Anonymous.IncrementingConstant;
            set => Anonymous.IncrementingConstant = value;
        }
#endif

    }
}
