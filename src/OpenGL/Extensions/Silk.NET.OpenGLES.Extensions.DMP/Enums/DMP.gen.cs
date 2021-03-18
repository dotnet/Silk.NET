// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.DMP
{
    [NativeName("Name", "GLenum")]
    public enum DMP : int
    {
        [NativeName("Name", "GL_SMAPHS30_PROGRAM_BINARY_DMP")]
        Smaphs30ProgramBinaryDmp = 0x9251,
        [NativeName("Name", "GL_SMAPHS_PROGRAM_BINARY_DMP")]
        SmaphsProgramBinaryDmp = 0x9252,
        [NativeName("Name", "GL_DMP_PROGRAM_BINARY_DMP")]
        DmpProgramBinaryDmp = 0x9253,
        [NativeName("Name", "GL_SHADER_BINARY_DMP")]
        ShaderBinaryDmp = 0x9250,
    }
}
