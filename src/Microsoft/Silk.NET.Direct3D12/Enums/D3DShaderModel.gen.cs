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
        [Obsolete("Deprecated in favour of \"ShaderModelNone\"")]
        [NativeName("Name", "D3D_SHADER_MODEL_NONE")]
        D3DShaderModelNone = 0x0,
        [Obsolete("Deprecated in favour of \"ShaderModel51\"")]
        [NativeName("Name", "D3D_SHADER_MODEL_5_1")]
        D3DShaderModel51 = 0x51,
        [Obsolete("Deprecated in favour of \"ShaderModel60\"")]
        [NativeName("Name", "D3D_SHADER_MODEL_6_0")]
        D3DShaderModel60 = 0x60,
        [Obsolete("Deprecated in favour of \"ShaderModel61\"")]
        [NativeName("Name", "D3D_SHADER_MODEL_6_1")]
        D3DShaderModel61 = 0x61,
        [Obsolete("Deprecated in favour of \"ShaderModel62\"")]
        [NativeName("Name", "D3D_SHADER_MODEL_6_2")]
        D3DShaderModel62 = 0x62,
        [Obsolete("Deprecated in favour of \"ShaderModel63\"")]
        [NativeName("Name", "D3D_SHADER_MODEL_6_3")]
        D3DShaderModel63 = 0x63,
        [Obsolete("Deprecated in favour of \"ShaderModel64\"")]
        [NativeName("Name", "D3D_SHADER_MODEL_6_4")]
        D3DShaderModel64 = 0x64,
        [Obsolete("Deprecated in favour of \"ShaderModel65\"")]
        [NativeName("Name", "D3D_SHADER_MODEL_6_5")]
        D3DShaderModel65 = 0x65,
        [Obsolete("Deprecated in favour of \"ShaderModel66\"")]
        [NativeName("Name", "D3D_SHADER_MODEL_6_6")]
        D3DShaderModel66 = 0x66,
        [Obsolete("Deprecated in favour of \"ShaderModel67\"")]
        [NativeName("Name", "D3D_SHADER_MODEL_6_7")]
        D3DShaderModel67 = 0x67,
        [Obsolete("Deprecated in favour of \"ShaderModel68\"")]
        [NativeName("Name", "D3D_SHADER_MODEL_6_8")]
        D3DShaderModel68 = 0x68,
        [Obsolete("Deprecated in favour of \"ShaderModel69\"")]
        [NativeName("Name", "D3D_SHADER_MODEL_6_9")]
        D3DShaderModel69 = 0x69,
        [Obsolete("Deprecated in favour of \"HighestShaderModel\"")]
        [NativeName("Name", "D3D_HIGHEST_SHADER_MODEL")]
        D3DHighestShaderModel = 0x69,
        [NativeName("Name", "D3D_SHADER_MODEL_NONE")]
        ShaderModelNone = 0x0,
        [NativeName("Name", "D3D_SHADER_MODEL_5_1")]
        ShaderModel51 = 0x51,
        [NativeName("Name", "D3D_SHADER_MODEL_6_0")]
        ShaderModel60 = 0x60,
        [NativeName("Name", "D3D_SHADER_MODEL_6_1")]
        ShaderModel61 = 0x61,
        [NativeName("Name", "D3D_SHADER_MODEL_6_2")]
        ShaderModel62 = 0x62,
        [NativeName("Name", "D3D_SHADER_MODEL_6_3")]
        ShaderModel63 = 0x63,
        [NativeName("Name", "D3D_SHADER_MODEL_6_4")]
        ShaderModel64 = 0x64,
        [NativeName("Name", "D3D_SHADER_MODEL_6_5")]
        ShaderModel65 = 0x65,
        [NativeName("Name", "D3D_SHADER_MODEL_6_6")]
        ShaderModel66 = 0x66,
        [NativeName("Name", "D3D_SHADER_MODEL_6_7")]
        ShaderModel67 = 0x67,
        [NativeName("Name", "D3D_SHADER_MODEL_6_8")]
        ShaderModel68 = 0x68,
        [NativeName("Name", "D3D_SHADER_MODEL_6_9")]
        ShaderModel69 = 0x69,
        [NativeName("Name", "D3D_HIGHEST_SHADER_MODEL")]
        HighestShaderModel = 0x69,
    }
}
