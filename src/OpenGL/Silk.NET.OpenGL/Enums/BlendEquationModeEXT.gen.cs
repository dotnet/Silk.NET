// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
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
