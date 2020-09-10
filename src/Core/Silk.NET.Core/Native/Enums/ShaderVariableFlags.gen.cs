// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "_D3D_SHADER_VARIABLE_FLAGS")]
    public enum ShaderVariableFlags
    {
        [NativeName("Name", "D3D_SVF_USERPACKED")]
        SvfUserpacked = 0x1,
        [NativeName("Name", "D3D_SVF_USED")]
        SvfUsed = 0x2,
        [NativeName("Name", "D3D_SVF_INTERFACE_POINTER")]
        SvfInterfacePointer = 0x4,
        [NativeName("Name", "D3D_SVF_INTERFACE_PARAMETER")]
        SvfInterfaceParameter = 0x8,
        [NativeName("Name", "D3D10_SVF_USERPACKED")]
        D3D10SvfUserpacked = 0x1,
        [NativeName("Name", "D3D10_SVF_USED")]
        D3D10SvfUsed = 0x2,
        [NativeName("Name", "D3D11_SVF_INTERFACE_POINTER")]
        D3D11SvfInterfacePointer = 0x4,
        [NativeName("Name", "D3D11_SVF_INTERFACE_PARAMETER")]
        D3D11SvfInterfaceParameter = 0x8,
        [NativeName("Name", "D3D_SVF_FORCE_DWORD")]
        SvfForceDword = 0x7FFFFFFF,
    }
}
