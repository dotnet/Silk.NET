// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "FragmentShaderDestMaskATI")]
    public enum FragmentShaderDestMaskATI : int
    {
        [NativeName("Name", "GL_RED_BIT_ATI")]
        RedBitAti = 0x1,
        [NativeName("Name", "GL_GREEN_BIT_ATI")]
        GreenBitAti = 0x2,
        [NativeName("Name", "GL_BLUE_BIT_ATI")]
        BlueBitAti = 0x4,
    }
}
