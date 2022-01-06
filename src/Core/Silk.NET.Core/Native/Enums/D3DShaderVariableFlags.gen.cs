// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [Flags]
    [NativeName("Name", "_D3D_SHADER_VARIABLE_FLAGS")]
    public enum D3DShaderVariableFlags : int
    {
        [NativeName("Name", "D3D_SVF_USERPACKED")]
        D3DSvfUserpacked = 0x1,
        [NativeName("Name", "D3D_SVF_USED")]
        D3DSvfUsed = 0x2,
        [NativeName("Name", "D3D_SVF_INTERFACE_POINTER")]
        D3DSvfInterfacePointer = 0x4,
        [NativeName("Name", "D3D_SVF_INTERFACE_PARAMETER")]
        D3DSvfInterfaceParameter = 0x8,
        [NativeName("Name", "D3D10_SVF_USERPACKED")]
        D3D10SvfUserpacked = 0x1,
        [NativeName("Name", "D3D10_SVF_USED")]
        D3D10SvfUsed = 0x2,
        [NativeName("Name", "D3D11_SVF_INTERFACE_POINTER")]
        D3D11SvfInterfacePointer = 0x4,
        [NativeName("Name", "D3D11_SVF_INTERFACE_PARAMETER")]
        D3D11SvfInterfaceParameter = 0x8,
        [NativeName("Name", "D3D_SVF_FORCE_DWORD")]
        D3DSvfForceDword = 0x7FFFFFFF,
    }
}
