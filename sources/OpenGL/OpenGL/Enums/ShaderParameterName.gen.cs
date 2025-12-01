// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ShaderParameterName")]
public enum ShaderParameterName : uint
{
    [NativeName("GL_SHADER_TYPE")]
    ShaderType = unchecked((uint)0x8B4F),

    [NativeName("GL_DELETE_STATUS")]
    DeleteStatus = unchecked((uint)0x8B80),

    [NativeName("GL_COMPILE_STATUS")]
    CompileStatus = unchecked((uint)0x8B81),

    [NativeName("GL_INFO_LOG_LENGTH")]
    InfoLogLength = unchecked((uint)0x8B84),

    [NativeName("GL_SHADER_SOURCE_LENGTH")]
    ShaderSourceLength = unchecked((uint)0x8B88),
}
