// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "EXT", -1)]
[NativeName("BlendEquationModeEXT")]
public enum BlendEquationMode : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MIN_EXT")]
    MinEXT = 32775,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_EXT")]
    MaxEXT = 32776,

    [NativeName("GL_FUNC_ADD")]
    FuncAdd = 32774,

    [NativeName("GL_FUNC_REVERSE_SUBTRACT")]
    FuncReverseSubtract = 32779,

    [NativeName("GL_FUNC_SUBTRACT")]
    FuncSubtract = 32778,

    [NativeName("GL_MIN")]
    Min = 32775,

    [NativeName("GL_MAX")]
    Max = 32776,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FUNC_ADD_EXT")]
    FuncAddEXT = 32774,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FUNC_SUBTRACT_EXT")]
    FuncSubtractEXT = 32778,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FUNC_REVERSE_SUBTRACT_EXT")]
    FuncReverseSubtractEXT = 32779,

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_ALPHA_MIN_SGIX")]
    AlphaMinSGIX = 33568,

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_ALPHA_MAX_SGIX")]
    AlphaMaxSGIX = 33569,
}
