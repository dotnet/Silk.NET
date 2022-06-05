// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D_SHADER_MODEL")]
    public enum D3DShaderModel : int
    {
        [Obsolete("Deprecated in favour of \"Model51\"")]
        [NativeName("Name", "D3D_SHADER_MODEL_5_1")]
        D3DShaderModel51 = 0x51,
        [Obsolete("Deprecated in favour of \"Model60\"")]
        [NativeName("Name", "D3D_SHADER_MODEL_6_0")]
        D3DShaderModel60 = 0x60,
        [Obsolete("Deprecated in favour of \"Model61\"")]
        [NativeName("Name", "D3D_SHADER_MODEL_6_1")]
        D3DShaderModel61 = 0x61,
        [Obsolete("Deprecated in favour of \"Model62\"")]
        [NativeName("Name", "D3D_SHADER_MODEL_6_2")]
        D3DShaderModel62 = 0x62,
        [Obsolete("Deprecated in favour of \"Model63\"")]
        [NativeName("Name", "D3D_SHADER_MODEL_6_3")]
        D3DShaderModel63 = 0x63,
        [Obsolete("Deprecated in favour of \"Model64\"")]
        [NativeName("Name", "D3D_SHADER_MODEL_6_4")]
        D3DShaderModel64 = 0x64,
        [Obsolete("Deprecated in favour of \"Model65\"")]
        [NativeName("Name", "D3D_SHADER_MODEL_6_5")]
        D3DShaderModel65 = 0x65,
        [Obsolete("Deprecated in favour of \"Model66\"")]
        [NativeName("Name", "D3D_SHADER_MODEL_6_6")]
        D3DShaderModel66 = 0x66,
        [Obsolete("Deprecated in favour of \"Model67\"")]
        [NativeName("Name", "D3D_SHADER_MODEL_6_7")]
        D3DShaderModel67 = 0x67,
        [NativeName("Name", "D3D_SHADER_MODEL_5_1")]
        Model51 = 0x51,
        [NativeName("Name", "D3D_SHADER_MODEL_6_0")]
        Model60 = 0x60,
        [NativeName("Name", "D3D_SHADER_MODEL_6_1")]
        Model61 = 0x61,
        [NativeName("Name", "D3D_SHADER_MODEL_6_2")]
        Model62 = 0x62,
        [NativeName("Name", "D3D_SHADER_MODEL_6_3")]
        Model63 = 0x63,
        [NativeName("Name", "D3D_SHADER_MODEL_6_4")]
        Model64 = 0x64,
        [NativeName("Name", "D3D_SHADER_MODEL_6_5")]
        Model65 = 0x65,
        [NativeName("Name", "D3D_SHADER_MODEL_6_6")]
        Model66 = 0x66,
        [NativeName("Name", "D3D_SHADER_MODEL_6_7")]
        Model67 = 0x67,
    }
}
