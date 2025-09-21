// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ShaderBinaryFormat")]
    public enum ShaderBinaryFormat : int
    {
        [NativeName("Name", "GL_SGX_BINARY_IMG")]
        SgxBinaryImg = 0x8C0A,
        [NativeName("Name", "GL_MALI_SHADER_BINARY_ARM")]
        MaliShaderBinaryArm = 0x8F60,
        [NativeName("Name", "GL_SHADER_BINARY_VIV")]
        ShaderBinaryViv = 0x8FC4,
        [NativeName("Name", "GL_SHADER_BINARY_DMP")]
        ShaderBinaryDmp = 0x9250,
        [NativeName("Name", "GL_GCCSO_SHADER_BINARY_FJ")]
        GccsoShaderBinaryFJ = 0x9260,
        [NativeName("Name", "GL_SHADER_BINARY_FORMAT_SPIR_V")]
        ShaderBinaryFormatSpirV = 0x9551,
        [NativeName("Name", "GL_HUAWEI_SHADER_BINARY")]
        HuaweiShaderBinary = 0x9770,
    }
}
