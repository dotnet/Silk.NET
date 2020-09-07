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
    [NativeName("Name", "D3D11_SHADER_TRACE_DESC")]
    public unsafe partial struct ShaderTraceDesc
    {
        public ShaderTraceDesc
        (
            ShaderType type = default,
            uint flags = default
        )
        {
            Type = type;
            Flags = flags;
        }


        [NativeName("Type", "D3D11_SHADER_TYPE")]
        [NativeName("Type.Name", "D3D11_SHADER_TYPE")]
        [NativeName("Name", "Type")]
        public ShaderType Type;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Flags")]
        public uint Flags;
    }
}
