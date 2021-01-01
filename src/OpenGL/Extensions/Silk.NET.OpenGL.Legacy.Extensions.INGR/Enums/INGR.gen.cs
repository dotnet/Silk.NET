// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.INGR
{
    [NativeName("Name", "GLenum")]
    public enum INGR : int
    {
        [NativeName("Name", "GL_RED_MIN_CLAMP_INGR")]
        RedMinClampIngr = 0x8560,
        [NativeName("Name", "GL_GREEN_MIN_CLAMP_INGR")]
        GreenMinClampIngr = 0x8561,
        [NativeName("Name", "GL_BLUE_MIN_CLAMP_INGR")]
        BlueMinClampIngr = 0x8562,
        [NativeName("Name", "GL_ALPHA_MIN_CLAMP_INGR")]
        AlphaMinClampIngr = 0x8563,
        [NativeName("Name", "GL_RED_MAX_CLAMP_INGR")]
        RedMaxClampIngr = 0x8564,
        [NativeName("Name", "GL_GREEN_MAX_CLAMP_INGR")]
        GreenMaxClampIngr = 0x8565,
        [NativeName("Name", "GL_BLUE_MAX_CLAMP_INGR")]
        BlueMaxClampIngr = 0x8566,
        [NativeName("Name", "GL_ALPHA_MAX_CLAMP_INGR")]
        AlphaMaxClampIngr = 0x8567,
        [NativeName("Name", "GL_INTERLACE_READ_INGR")]
        InterlaceReadIngr = 0x8568,
    }
}
