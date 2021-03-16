// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "VertexAttribEnumNV")]
    public enum VertexAttribEnumNV : int
    {
        [NativeName("Name", "GL_PROGRAM_PARAMETER_NV")]
        ProgramParameterNV = 0x8644,
    }
}
