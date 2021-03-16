// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "BlendEquationModeEXT")]
    public enum BlendEquationModeEXT : int
    {
        [NativeName("Name", "GL_FUNC_ADD")]
        FuncAdd = 0x8006,
        [NativeName("Name", "GL_FUNC_ADD_EXT")]
        FuncAddExt = 0x8006,
        [NativeName("Name", "GL_MIN")]
        Min = 0x8007,
        [NativeName("Name", "GL_MIN_EXT")]
        MinExt = 0x8007,
        [NativeName("Name", "GL_MAX")]
        Max = 0x8008,
        [NativeName("Name", "GL_MAX_EXT")]
        MaxExt = 0x8008,
        [NativeName("Name", "GL_FUNC_SUBTRACT")]
        FuncSubtract = 0x800A,
        [NativeName("Name", "GL_FUNC_SUBTRACT_EXT")]
        FuncSubtractExt = 0x800A,
        [NativeName("Name", "GL_FUNC_REVERSE_SUBTRACT")]
        FuncReverseSubtract = 0x800B,
        [NativeName("Name", "GL_FUNC_REVERSE_SUBTRACT_EXT")]
        FuncReverseSubtractExt = 0x800B,
        [NativeName("Name", "GL_ALPHA_MIN_SGIX")]
        AlphaMinSgix = 0x8320,
        [NativeName("Name", "GL_ALPHA_MAX_SGIX")]
        AlphaMaxSgix = 0x8321,
    }
}
