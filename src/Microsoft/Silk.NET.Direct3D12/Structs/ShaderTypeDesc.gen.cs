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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "_D3D12_SHADER_TYPE_DESC")]
    public unsafe partial struct ShaderTypeDesc
    {
        public ShaderTypeDesc
        (
            Silk.NET.Core.Native.D3DShaderVariableClass @class = default,
            Silk.NET.Core.Native.D3DShaderVariableType type = default,
            uint rows = default,
            uint columns = default,
            uint elements = default,
            uint members = default,
            uint offset = default,
            byte* name = default
        )
        {
            Class = @class;
            Type = type;
            Rows = rows;
            Columns = columns;
            Elements = elements;
            Members = members;
            Offset = offset;
            Name = name;
        }


        [NativeName("Type", "D3D_SHADER_VARIABLE_CLASS")]
        [NativeName("Type.Name", "D3D_SHADER_VARIABLE_CLASS")]
        [NativeName("Name", "Class")]
        public Silk.NET.Core.Native.D3DShaderVariableClass Class;

        [NativeName("Type", "D3D_SHADER_VARIABLE_TYPE")]
        [NativeName("Type.Name", "D3D_SHADER_VARIABLE_TYPE")]
        [NativeName("Name", "Type")]
        public Silk.NET.Core.Native.D3DShaderVariableType Type;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Rows")]
        public uint Rows;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Columns")]
        public uint Columns;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Elements")]
        public uint Elements;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Members")]
        public uint Members;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Offset")]
        public uint Offset;

        [NativeName("Type", "LPCSTR")]
        [NativeName("Type.Name", "LPCSTR")]
        [NativeName("Name", "Name")]
        public byte* Name;
    }
}
