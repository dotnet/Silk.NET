// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "SubroutineParameterName")]
    public enum SubroutineParameterName
    {
        [NativeName("Name", "GL_UNIFORM_SIZE")]
        UniformSize = 0x8A38,
        [NativeName("Name", "GL_UNIFORM_NAME_LENGTH")]
        UniformNameLength = 0x8A39,
        [NativeName("Name", "GL_NUM_COMPATIBLE_SUBROUTINES")]
        NumCompatibleSubroutines = 0x8E4A,
        [NativeName("Name", "GL_COMPATIBLE_SUBROUTINES")]
        CompatibleSubroutines = 0x8E4B,
    }
}
