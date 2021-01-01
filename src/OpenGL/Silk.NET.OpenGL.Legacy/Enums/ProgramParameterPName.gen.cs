// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "ProgramParameterPName")]
    public enum ProgramParameterPName : int
    {
        [NativeName("Name", "GL_PROGRAM_BINARY_RETRIEVABLE_HINT")]
        ProgramBinaryRetrievableHint = 0x8257,
        [NativeName("Name", "GL_PROGRAM_SEPARABLE")]
        ProgramSeparable = 0x8258,
    }
}
