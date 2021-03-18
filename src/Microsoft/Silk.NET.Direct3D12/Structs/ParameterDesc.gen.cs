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
    [NativeName("Name", "_D3D12_PARAMETER_DESC")]
    public unsafe partial struct ParameterDesc
    {
        public ParameterDesc
        (
            byte* name = null,
            byte* semanticName = null,
            Silk.NET.Core.Native.D3DShaderVariableType? type = null,
            Silk.NET.Core.Native.D3DShaderVariableClass? @class = null,
            uint? rows = null,
            uint? columns = null,
            Silk.NET.Core.Native.D3DInterpolationMode? interpolationMode = null,
            Silk.NET.Core.Native.D3DParameterFlags? flags = null,
            uint? firstInRegister = null,
            uint? firstInComponent = null,
            uint? firstOutRegister = null,
            uint? firstOutComponent = null
        ) : this()
        {
            if (name is not null)
            {
                Name = name;
            }

            if (semanticName is not null)
            {
                SemanticName = semanticName;
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (@class is not null)
            {
                Class = @class.Value;
            }

            if (rows is not null)
            {
                Rows = rows.Value;
            }

            if (columns is not null)
            {
                Columns = columns.Value;
            }

            if (interpolationMode is not null)
            {
                InterpolationMode = interpolationMode.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (firstInRegister is not null)
            {
                FirstInRegister = firstInRegister.Value;
            }

            if (firstInComponent is not null)
            {
                FirstInComponent = firstInComponent.Value;
            }

            if (firstOutRegister is not null)
            {
                FirstOutRegister = firstOutRegister.Value;
            }

            if (firstOutComponent is not null)
            {
                FirstOutComponent = firstOutComponent.Value;
            }
        }


        [NativeName("Type", "LPCSTR")]
        [NativeName("Type.Name", "LPCSTR")]
        [NativeName("Name", "Name")]
        public byte* Name;

        [NativeName("Type", "LPCSTR")]
        [NativeName("Type.Name", "LPCSTR")]
        [NativeName("Name", "SemanticName")]
        public byte* SemanticName;

        [NativeName("Type", "D3D_SHADER_VARIABLE_TYPE")]
        [NativeName("Type.Name", "D3D_SHADER_VARIABLE_TYPE")]
        [NativeName("Name", "Type")]
        public Silk.NET.Core.Native.D3DShaderVariableType Type;

        [NativeName("Type", "D3D_SHADER_VARIABLE_CLASS")]
        [NativeName("Type.Name", "D3D_SHADER_VARIABLE_CLASS")]
        [NativeName("Name", "Class")]
        public Silk.NET.Core.Native.D3DShaderVariableClass Class;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Rows")]
        public uint Rows;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Columns")]
        public uint Columns;

        [NativeName("Type", "D3D_INTERPOLATION_MODE")]
        [NativeName("Type.Name", "D3D_INTERPOLATION_MODE")]
        [NativeName("Name", "InterpolationMode")]
        public Silk.NET.Core.Native.D3DInterpolationMode InterpolationMode;

        [NativeName("Type", "D3D_PARAMETER_FLAGS")]
        [NativeName("Type.Name", "D3D_PARAMETER_FLAGS")]
        [NativeName("Name", "Flags")]
        public Silk.NET.Core.Native.D3DParameterFlags Flags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FirstInRegister")]
        public uint FirstInRegister;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FirstInComponent")]
        public uint FirstInComponent;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FirstOutRegister")]
        public uint FirstOutRegister;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FirstOutComponent")]
        public uint FirstOutComponent;
    }
}
