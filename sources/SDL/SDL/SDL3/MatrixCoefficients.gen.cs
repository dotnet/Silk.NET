// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_MatrixCoefficients")]
public enum MatrixCoefficients : uint
{
    [NativeName("SDL_MATRIX_COEFFICIENTS_IDENTITY")]
    Identity = 0,

    [NativeName("SDL_MATRIX_COEFFICIENTS_BT709")]
    Bt709 = 1,

    [NativeName("SDL_MATRIX_COEFFICIENTS_UNSPECIFIED")]
    Unspecified = 2,

    [NativeName("SDL_MATRIX_COEFFICIENTS_FCC")]
    Fcc = 4,

    [NativeName("SDL_MATRIX_COEFFICIENTS_BT470BG")]
    Bt470Bg = 5,

    [NativeName("SDL_MATRIX_COEFFICIENTS_BT601")]
    Bt601 = 6,

    [NativeName("SDL_MATRIX_COEFFICIENTS_SMPTE240")]
    Smpte240 = 7,

    [NativeName("SDL_MATRIX_COEFFICIENTS_YCGCO")]
    Ycgco = 8,

    [NativeName("SDL_MATRIX_COEFFICIENTS_BT2020_NCL")]
    Bt2020Ncl = 9,

    [NativeName("SDL_MATRIX_COEFFICIENTS_BT2020_CL")]
    Bt2020Cl = 10,

    [NativeName("SDL_MATRIX_COEFFICIENTS_SMPTE2085")]
    Smpte2085 = 11,

    [NativeName("SDL_MATRIX_COEFFICIENTS_CHROMA_DERIVED_NCL")]
    ChromaDerivedNcl = 12,

    [NativeName("SDL_MATRIX_COEFFICIENTS_CHROMA_DERIVED_CL")]
    ChromaDerivedCl = 13,

    [NativeName("SDL_MATRIX_COEFFICIENTS_ICTCP")]
    Ictcp = 14,

    [NativeName("SDL_MATRIX_COEFFICIENTS_CUSTOM")]
    Custom = 31,
}
