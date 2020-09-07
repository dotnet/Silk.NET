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
    [NativeName("Name", "_D3D11_SHADER_INPUT_BIND_DESC")]
    public unsafe partial struct ShaderInputBindDesc
    {
        public ShaderInputBindDesc
        (
            byte* name = default,
            D3DShaderInputType type = default,
            uint bindPoint = default,
            uint bindCount = default,
            uint uFlags = default,
            D3DResourceReturnType returnType = default,
            D3DSrvDimension dimension = default,
            uint numSamples = default
        )
        {
            Name = name;
            Type = type;
            BindPoint = bindPoint;
            BindCount = bindCount;
            UFlags = uFlags;
            ReturnType = returnType;
            Dimension = dimension;
            NumSamples = numSamples;
        }


        [NativeName("Type", "LPCSTR")]
        [NativeName("Type.Name", "LPCSTR")]
        [NativeName("Name", "Name")]
        public byte* Name;

        [NativeName("Type", "D3D_SHADER_INPUT_TYPE")]
        [NativeName("Type.Name", "D3D_SHADER_INPUT_TYPE")]
        [NativeName("Name", "Type")]
        public D3DShaderInputType Type;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BindPoint")]
        public uint BindPoint;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BindCount")]
        public uint BindCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "uFlags")]
        public uint UFlags;

        [NativeName("Type", "D3D_RESOURCE_RETURN_TYPE")]
        [NativeName("Type.Name", "D3D_RESOURCE_RETURN_TYPE")]
        [NativeName("Name", "ReturnType")]
        public D3DResourceReturnType ReturnType;

        [NativeName("Type", "D3D_SRV_DIMENSION")]
        [NativeName("Type.Name", "D3D_SRV_DIMENSION")]
        [NativeName("Name", "Dimension")]
        public D3DSrvDimension Dimension;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumSamples")]
        public uint NumSamples;
    }
}
