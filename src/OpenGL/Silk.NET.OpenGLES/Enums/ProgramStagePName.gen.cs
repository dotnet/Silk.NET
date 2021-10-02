// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ProgramStagePName")]
    public enum ProgramStagePName : int
    {
        [NativeName("Name", "GL_ACTIVE_SUBROUTINES")]
        ActiveSubroutines = 0x8DE5,
        [NativeName("Name", "GL_ACTIVE_SUBROUTINE_UNIFORMS")]
        ActiveSubroutineUniforms = 0x8DE6,
        [NativeName("Name", "GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS")]
        ActiveSubroutineUniformLocations = 0x8E47,
        [NativeName("Name", "GL_ACTIVE_SUBROUTINE_MAX_LENGTH")]
        ActiveSubroutineMaxLength = 0x8E48,
        [NativeName("Name", "GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH")]
        ActiveSubroutineUniformMaxLength = 0x8E49,
    }
}
