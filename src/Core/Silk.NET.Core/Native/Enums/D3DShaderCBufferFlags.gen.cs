// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "_D3D_SHADER_CBUFFER_FLAGS")]
    public enum D3DShaderCBufferFlags : int
    {
        [NativeName("Name", "D3D_CBF_USERPACKED")]
        D3DCbfUserpacked = 0x1,
        [NativeName("Name", "D3D10_CBF_USERPACKED")]
        D3D10CbfUserpacked = 0x1,
        [NativeName("Name", "D3D_CBF_FORCE_DWORD")]
        D3DCbfForceDword = 0x7FFFFFFF,
    }
}
