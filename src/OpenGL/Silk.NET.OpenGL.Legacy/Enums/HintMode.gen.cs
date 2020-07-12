// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "HintMode")]
    public enum HintMode
    {
        [NativeName("Name", "GL_DONT_CARE")]
        DontCare = 0x1100,
        [NativeName("Name", "GL_FASTEST")]
        Fastest = 0x1101,
        [NativeName("Name", "GL_NICEST")]
        Nicest = 0x1102,
    }
}
