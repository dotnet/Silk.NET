// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.HUAWEI
{
    [NativeName("Name", "GLenum")]
    public enum HUAWEI : int
    {
        [Obsolete("Deprecated in favour of \"ProgramBinary\"")]
        [NativeName("Name", "GL_HUAWEI_PROGRAM_BINARY")]
        HuaweiProgramBinary = 0x9771,
        [Obsolete("Deprecated in favour of \"ShaderBinary\"")]
        [NativeName("Name", "GL_HUAWEI_SHADER_BINARY")]
        HuaweiShaderBinary = 0x9770,
        [NativeName("Name", "GL_HUAWEI_PROGRAM_BINARY")]
        ProgramBinary = 0x9771,
        [NativeName("Name", "GL_HUAWEI_SHADER_BINARY")]
        ShaderBinary = 0x9770,
    }
}
