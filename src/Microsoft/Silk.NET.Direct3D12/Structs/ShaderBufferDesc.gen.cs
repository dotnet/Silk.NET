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
    [NativeName("Name", "_D3D12_SHADER_BUFFER_DESC")]
    public unsafe partial struct ShaderBufferDesc
    {
        public ShaderBufferDesc
        (
            byte* name = null,
            Silk.NET.Core.Native.D3DCBufferType? type = null,
            uint? variables = null,
            uint? size = null,
            uint? uFlags = null
        ) : this()
        {
            if (name is not null)
            {
                Name = name;
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (variables is not null)
            {
                Variables = variables.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (uFlags is not null)
            {
                UFlags = uFlags.Value;
            }
        }


        [NativeName("Type", "LPCSTR")]
        [NativeName("Type.Name", "LPCSTR")]
        [NativeName("Name", "Name")]
        public byte* Name;

        [NativeName("Type", "D3D_CBUFFER_TYPE")]
        [NativeName("Type.Name", "D3D_CBUFFER_TYPE")]
        [NativeName("Name", "Type")]
        public Silk.NET.Core.Native.D3DCBufferType Type;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Variables")]
        public uint Variables;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Size")]
        public uint Size;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "uFlags")]
        public uint UFlags;
    }
}
