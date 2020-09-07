// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "_D3D11_SHADER_BUFFER_DESC")]
    public unsafe partial struct ShaderBufferDesc
    {
        public ShaderBufferDesc
        (
            byte* name = default,
            D3DCbufferType type = default,
            uint variables = default,
            uint size = default,
            uint uFlags = default
        )
        {
            Name = name;
            Type = type;
            Variables = variables;
            Size = size;
            UFlags = uFlags;
        }


        [NativeName("Type", "LPCSTR")]
        [NativeName("Type.Name", "LPCSTR")]
        [NativeName("Name", "Name")]
        public byte* Name;

        [NativeName("Type", "D3D_CBUFFER_TYPE")]
        [NativeName("Type.Name", "D3D_CBUFFER_TYPE")]
        [NativeName("Name", "Type")]
        public D3DCbufferType Type;

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
