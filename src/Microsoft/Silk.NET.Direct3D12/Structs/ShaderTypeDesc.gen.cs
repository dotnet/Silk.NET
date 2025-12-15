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
    [NativeName("Name", "_D3D12_SHADER_TYPE_DESC")]
    public unsafe partial struct ShaderTypeDesc
    {
        public ShaderTypeDesc
        (
            Silk.NET.Core.Native.D3DShaderVariableClass? @class = null,
            Silk.NET.Core.Native.D3DShaderVariableType? type = null,
            uint? rows = null,
            uint? columns = null,
            uint? elements = null,
            uint? members = null,
            uint? offset = null,
            byte* name = null
        ) : this()
        {
            if (@class is not null)
            {
                Class = @class.Value;
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (rows is not null)
            {
                Rows = rows.Value;
            }

            if (columns is not null)
            {
                Columns = columns.Value;
            }

            if (elements is not null)
            {
                Elements = elements.Value;
            }

            if (members is not null)
            {
                Members = members.Value;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (name is not null)
            {
                Name = name;
            }
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
