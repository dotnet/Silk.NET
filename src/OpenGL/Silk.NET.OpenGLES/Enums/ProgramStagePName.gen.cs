// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
