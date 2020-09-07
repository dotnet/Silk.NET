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
    [NativeName("Name", "_D3D11_PARAMETER_DESC")]
    public unsafe partial struct ParameterDesc
    {
        public ParameterDesc
        (
            byte* name = default,
            byte* semanticName = default,
            D3DShaderVariableType type = default,
            D3DShaderVariableClass @class = default,
            uint rows = default,
            uint columns = default,
            D3DInterpolationMode interpolationMode = default,
            D3DParameterFlags flags = default,
            uint firstInRegister = default,
            uint firstInComponent = default,
            uint firstOutRegister = default,
            uint firstOutComponent = default
        )
        {
            Name = name;
            SemanticName = semanticName;
            Type = type;
            Class = @class;
            Rows = rows;
            Columns = columns;
            InterpolationMode = interpolationMode;
            Flags = flags;
            FirstInRegister = firstInRegister;
            FirstInComponent = firstInComponent;
            FirstOutRegister = firstOutRegister;
            FirstOutComponent = firstOutComponent;
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
        public D3DShaderVariableType Type;

        [NativeName("Type", "D3D_SHADER_VARIABLE_CLASS")]
        [NativeName("Type.Name", "D3D_SHADER_VARIABLE_CLASS")]
        [NativeName("Name", "Class")]
        public D3DShaderVariableClass Class;

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
        public D3DInterpolationMode InterpolationMode;

        [NativeName("Type", "D3D_PARAMETER_FLAGS")]
        [NativeName("Type.Name", "D3D_PARAMETER_FLAGS")]
        [NativeName("Name", "Flags")]
        public D3DParameterFlags Flags;

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
