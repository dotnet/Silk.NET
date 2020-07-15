// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "AccumOp")]
    public enum AccumOp
    {
        [NativeName("Name", "GL_ACCUM")]
        Accum = 0x100,
        [NativeName("Name", "GL_LOAD")]
        Load = 0x101,
        [NativeName("Name", "GL_RETURN")]
        Return = 0x102,
        [NativeName("Name", "GL_MULT")]
        Mult = 0x103,
        [NativeName("Name", "GL_ADD")]
        Add = 0x104,
    }
}
