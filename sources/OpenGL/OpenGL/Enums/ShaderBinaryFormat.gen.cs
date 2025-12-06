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
    ShaderBinaryFormatSpirV = 38225,

    [NativeName("GL_MALI_SHADER_BINARY_ARM")]
    MaliShaderBinaryARM = 36704,

    [NativeName("GL_SHADER_BINARY_DMP")]
    ShaderBinaryDMP = 37456,

    [NativeName("GL_GCCSO_SHADER_BINARY_FJ")]
    GccsoShaderBinaryFJ = 37472,

    [NativeName("GL_SGX_BINARY_IMG")]
    SgxBinaryIMG = 35850,

    [NativeName("GL_SHADER_BINARY_VIV")]
    ShaderBinaryVIV = 36804,
}
