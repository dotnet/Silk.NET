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
    [NativeName("Name", "D3D12_ROOT_PARAMETER")]
    public unsafe partial struct RootParameter
    {
        public RootParameter
        (
            RootParameterType parameterType = default,
            ShaderVisibility shaderVisibility = default
        )
        {
            ParameterType = parameterType;
            ShaderVisibility = shaderVisibility;
        }


        [NativeName("Type", "D3D12_ROOT_PARAMETER_TYPE")]
        [NativeName("Type.Name", "D3D12_ROOT_PARAMETER_TYPE")]
        [NativeName("Name", "ParameterType")]
        public RootParameterType ParameterType;

        [NativeName("Type", "D3D12_SHADER_VISIBILITY")]
        [NativeName("Type.Name", "D3D12_SHADER_VISIBILITY")]
        [NativeName("Name", "ShaderVisibility")]
        public ShaderVisibility ShaderVisibility;
    }
}
