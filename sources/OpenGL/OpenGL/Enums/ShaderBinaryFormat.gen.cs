// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ShaderBinaryFormat")]
public enum ShaderBinaryFormat : uint
{
    [NativeName("GL_SHADER_BINARY_FORMAT_SPIR_V")]
    ShaderBinaryFormatSpirV = unchecked((uint)0x9551),

    [NativeName("GL_MALI_SHADER_BINARY_ARM")]
    MaliShaderBinaryARM = unchecked((uint)0x8F60),

    [NativeName("GL_SHADER_BINARY_DMP")]
    ShaderBinaryDMP = unchecked((uint)0x9250),

    [NativeName("GL_GCCSO_SHADER_BINARY_FJ")]
    GccsoShaderBinaryFJ = unchecked((uint)0x9260),

    [NativeName("GL_SGX_BINARY_IMG")]
    SgxBinaryIMG = unchecked((uint)0x8C0A),

    [NativeName("GL_SHADER_BINARY_VIV")]
    ShaderBinaryVIV = unchecked((uint)0x8FC4),
}
