// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeTypeName("unsigned int")]
public enum MatrixCoefficients : uint
{
    Identity = 0,
    Bt709 = 1,
    Unspecified = 2,
    Fcc = 4,
    Bt470Bg = 5,
    Bt601 = 6,
    Smpte240 = 7,
    Ycgco = 8,
    Bt2020Ncl = 9,
    Bt2020Cl = 10,
    Smpte2085 = 11,
    ChromaDerivedNcl = 12,
    ChromaDerivedCl = 13,
    Ictcp = 14,
    Custom = 31,
}
