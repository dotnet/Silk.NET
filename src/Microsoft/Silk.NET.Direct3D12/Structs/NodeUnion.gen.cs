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
    [NativeName("Name", "__AnonymousRecord_d3d12_L14411_C5")]
    public unsafe partial struct NodeUnion
    {
        public NodeUnion
        (
            ShaderNode? shader = null
        ) : this()
        {
            if (shader is not null)
            {
                Shader = shader.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_SHADER_NODE")]
        [NativeName("Type.Name", "D3D12_SHADER_NODE")]
        [NativeName("Name", "Shader")]
        public ShaderNode Shader;
    }
}
