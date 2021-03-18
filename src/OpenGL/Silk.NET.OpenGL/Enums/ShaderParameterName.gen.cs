// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "ShaderParameterName")]
    public enum ShaderParameterName : int
    {
        [NativeName("Name", "GL_SHADER_TYPE")]
        ShaderType = 0x8B4F,
        [NativeName("Name", "GL_DELETE_STATUS")]
        DeleteStatus = 0x8B80,
        [NativeName("Name", "GL_COMPILE_STATUS")]
        CompileStatus = 0x8B81,
        [NativeName("Name", "GL_INFO_LOG_LENGTH")]
        InfoLogLength = 0x8B84,
        [NativeName("Name", "GL_SHADER_SOURCE_LENGTH")]
        ShaderSourceLength = 0x8B88,
    }
}
