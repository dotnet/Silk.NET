// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("BlendEquationModeEXT")]
[Transformed]
public enum BlendEquationModeExt : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MIN_EXT")]
    Minext = unchecked((uint)0x8007),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_EXT")]
    Maxext = unchecked((uint)0x8008),

    [NativeName("GL_FUNC_ADD")]
    FuncAdd = unchecked((uint)0x8006),

    [NativeName("GL_FUNC_REVERSE_SUBTRACT")]
    FuncReverseSubtract = unchecked((uint)0x800B),

    [NativeName("GL_FUNC_SUBTRACT")]
    FuncSubtract = unchecked((uint)0x800A),

    [NativeName("GL_MIN")]
    Min = unchecked((uint)0x8007),

    [NativeName("GL_MAX")]
    Max = unchecked((uint)0x8008),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FUNC_ADD_EXT")]
    FuncAddext = unchecked((uint)0x8006),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FUNC_SUBTRACT_EXT")]
    FuncSubtractext = unchecked((uint)0x800A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FUNC_REVERSE_SUBTRACT_EXT")]
    FuncReverseSubtractext = unchecked((uint)0x800B),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_ALPHA_MIN_SGIX")]
    AlphaMinsgix = unchecked((uint)0x8320),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_ALPHA_MAX_SGIX")]
    AlphaMaxsgix = unchecked((uint)0x8321),
}
