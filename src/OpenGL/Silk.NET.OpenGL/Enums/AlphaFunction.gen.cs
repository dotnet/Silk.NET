// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "AlphaFunction")]
    public enum AlphaFunction
    {
        [NativeName("Name", "GL_NEVER")]
        Never = 0x200,
        [NativeName("Name", "GL_LESS")]
        Less = 0x201,
        [NativeName("Name", "GL_EQUAL")]
        Equal = 0x202,
        [NativeName("Name", "GL_LEQUAL")]
        Lequal = 0x203,
        [NativeName("Name", "GL_GREATER")]
        Greater = 0x204,
        [NativeName("Name", "GL_NOTEQUAL")]
        Notequal = 0x205,
        [NativeName("Name", "GL_GEQUAL")]
        Gequal = 0x206,
        [NativeName("Name", "GL_ALWAYS")]
        Always = 0x207,
    }
}
