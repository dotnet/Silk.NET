// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "NV", -1)]
[NativeName("CombinerRegisterNV")]
public enum CombinerRegister : uint
{
    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE0_ARB")]
    Texture0ARB = 33984,

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE1_ARB")]
    Texture1ARB = 33985,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PRIMARY_COLOR_NV")]
    PrimaryColorNV = 34092,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SECONDARY_COLOR_NV")]
    SecondaryColorNV = 34093,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SPARE0_NV")]
    Spare0NV = 34094,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SPARE1_NV")]
    Spare1NV = 34095,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DISCARD_NV")]
    DiscardNV = 34096,
}
