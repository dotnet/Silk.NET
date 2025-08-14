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
    [NativeName("Name", "D3D12_NODE")]
    public unsafe partial struct Node
    {
        public Node
        (
            NodeType? nodeType = null,
            NodeUnion? anonymous = null,
            ShaderNode? shader = null
        ) : this()
        {
            if (nodeType is not null)
            {
                NodeType = nodeType.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (shader is not null)
            {
                Shader = shader.Value;
            }
        }


        [NativeName("Type", "D3D12_NODE_TYPE")]
        [NativeName("Type.Name", "D3D12_NODE_TYPE")]
        [NativeName("Name", "NodeType")]
        public NodeType NodeType;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12_L14411_C5")]
        [NativeName("Name", "anonymous1")]
        public NodeUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ShaderNode Shader
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Shader;
        }
#else
        public ShaderNode Shader
        {
            get => Anonymous.Shader;
            set => Anonymous.Shader = value;
        }
#endif

    }
}
