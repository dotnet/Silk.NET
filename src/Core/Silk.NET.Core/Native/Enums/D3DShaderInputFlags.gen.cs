// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [Flags]
    [NativeName("Name", "_D3D_SHADER_INPUT_FLAGS")]
    public enum D3DShaderInputFlags : int
    {
        [NativeName("Name", "D3D_SIF_USERPACKED")]
        D3DSifUserpacked = 0x1,
        [NativeName("Name", "D3D_SIF_COMPARISON_SAMPLER")]
        D3DSifComparisonSampler = 0x2,
        [NativeName("Name", "D3D_SIF_TEXTURE_COMPONENT_0")]
        D3DSifTextureComponent0 = 0x4,
        [NativeName("Name", "D3D_SIF_TEXTURE_COMPONENT_1")]
        D3DSifTextureComponent1 = 0x8,
        [NativeName("Name", "D3D_SIF_TEXTURE_COMPONENTS")]
        D3DSifTextureComponents = 0xC,
        [NativeName("Name", "D3D_SIF_UNUSED")]
        D3DSifUnused = 0x10,
        [NativeName("Name", "D3D10_SIF_USERPACKED")]
        D3D10SifUserpacked = 0x1,
        [NativeName("Name", "D3D10_SIF_COMPARISON_SAMPLER")]
        D3D10SifComparisonSampler = 0x2,
        [NativeName("Name", "D3D10_SIF_TEXTURE_COMPONENT_0")]
        D3D10SifTextureComponent0 = 0x4,
        [NativeName("Name", "D3D10_SIF_TEXTURE_COMPONENT_1")]
        D3D10SifTextureComponent1 = 0x8,
        [NativeName("Name", "D3D10_SIF_TEXTURE_COMPONENTS")]
        D3D10SifTextureComponents = 0xC,
        [NativeName("Name", "D3D_SIF_FORCE_DWORD")]
        D3DSifForceDword = 0x7FFFFFFF,
    }
}
