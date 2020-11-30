// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12_L3951_C5")]
    public unsafe partial struct AnonymousRecordD3d12L3951C5
    {
        public AnonymousRecordD3d12L3951C5
        (
            AnonymousRecordD3d12L3953C9? vertexBuffer = null,
            AnonymousRecordD3d12L3957C9? constant = null,
            AnonymousRecordD3d12L3963C9? constantBufferView = null,
            AnonymousRecordD3d12L3967C9? shaderResourceView = null,
            AnonymousRecordD3d12L3971C9? unorderedAccessView = null
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
        }


        [FieldOffset(0)]
        [NativeName("Type", "struct (anonymous struct at d3d12.h:3953:9)")]
        [NativeName("Type.Name", "struct (anonymous struct at d3d12.h:3953:9)")]
        [NativeName("Name", "VertexBuffer")]
        public AnonymousRecordD3d12L3953C9 VertexBuffer;

        [FieldOffset(0)]
        [NativeName("Type", "struct (anonymous struct at d3d12.h:3957:9)")]
        [NativeName("Type.Name", "struct (anonymous struct at d3d12.h:3957:9)")]
        [NativeName("Name", "Constant")]
        public AnonymousRecordD3d12L3957C9 Constant;

        [FieldOffset(0)]
        [NativeName("Type", "struct (anonymous struct at d3d12.h:3963:9)")]
        [NativeName("Type.Name", "struct (anonymous struct at d3d12.h:3963:9)")]
        [NativeName("Name", "ConstantBufferView")]
        public AnonymousRecordD3d12L3963C9 ConstantBufferView;

        [FieldOffset(0)]
        [NativeName("Type", "struct (anonymous struct at d3d12.h:3967:9)")]
        [NativeName("Type.Name", "struct (anonymous struct at d3d12.h:3967:9)")]
        [NativeName("Name", "ShaderResourceView")]
        public AnonymousRecordD3d12L3967C9 ShaderResourceView;

        [FieldOffset(0)]
        [NativeName("Type", "struct (anonymous struct at d3d12.h:3971:9)")]
        [NativeName("Type.Name", "struct (anonymous struct at d3d12.h:3971:9)")]
        [NativeName("Name", "UnorderedAccessView")]
        public AnonymousRecordD3d12L3971C9 UnorderedAccessView;
    }
}
