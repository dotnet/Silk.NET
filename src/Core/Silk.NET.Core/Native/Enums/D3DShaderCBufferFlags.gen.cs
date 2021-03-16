// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
