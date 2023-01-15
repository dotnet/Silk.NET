// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "ProgramStagePName")]
    public enum ProgramStagePName : int
    {
        [Obsolete("Deprecated in favour of \"Subroutines\"")]
        [NativeName("Name", "GL_ACTIVE_SUBROUTINES")]
        ActiveSubroutines = 0x8DE5,
        [Obsolete("Deprecated in favour of \"SubroutineUniforms\"")]
        [NativeName("Name", "GL_ACTIVE_SUBROUTINE_UNIFORMS")]
        ActiveSubroutineUniforms = 0x8DE6,
        [Obsolete("Deprecated in favour of \"SubroutineUniformLocations\"")]
        [NativeName("Name", "GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS")]
        ActiveSubroutineUniformLocations = 0x8E47,
        [Obsolete("Deprecated in favour of \"SubroutineMaxLength\"")]
        [NativeName("Name", "GL_ACTIVE_SUBROUTINE_MAX_LENGTH")]
        ActiveSubroutineMaxLength = 0x8E48,
        [Obsolete("Deprecated in favour of \"SubroutineUniformMaxLength\"")]
        [NativeName("Name", "GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH")]
        ActiveSubroutineUniformMaxLength = 0x8E49,
        [NativeName("Name", "GL_ACTIVE_SUBROUTINES")]
        Subroutines = 0x8DE5,
        [NativeName("Name", "GL_ACTIVE_SUBROUTINE_UNIFORMS")]
        SubroutineUniforms = 0x8DE6,
        [NativeName("Name", "GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS")]
        SubroutineUniformLocations = 0x8E47,
        [NativeName("Name", "GL_ACTIVE_SUBROUTINE_MAX_LENGTH")]
        SubroutineMaxLength = 0x8E48,
        [NativeName("Name", "GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH")]
        SubroutineUniformMaxLength = 0x8E49,
    }
}
