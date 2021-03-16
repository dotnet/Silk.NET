// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "ProgramStringProperty")]
    public enum ProgramStringProperty : int
    {
        [NativeName("Name", "GL_PROGRAM_STRING_ARB")]
        ProgramStringArb = 0x8628,
    }
}
