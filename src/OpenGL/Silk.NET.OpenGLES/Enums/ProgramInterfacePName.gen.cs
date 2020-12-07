// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ProgramInterfacePName")]
    public enum ProgramInterfacePName
    {
        [NativeName("Name", "GL_ACTIVE_RESOURCES")]
        ActiveResources = 0x92F5,
        [NativeName("Name", "GL_MAX_NAME_LENGTH")]
        MaxNameLength = 0x92F6,
        [NativeName("Name", "GL_MAX_NUM_ACTIVE_VARIABLES")]
        MaxNumActiveVariables = 0x92F7,
        [NativeName("Name", "GL_MAX_NUM_COMPATIBLE_SUBROUTINES")]
        MaxNumCompatibleSubroutines = 0x92F8,
    }
}
