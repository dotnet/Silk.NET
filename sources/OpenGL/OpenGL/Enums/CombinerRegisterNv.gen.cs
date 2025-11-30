// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "NV", 0)]
[NativeName("CombinerRegisterNV")]
[Transformed]
public enum CombinerRegisterNv : uint
{
    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE0_ARB")]
    Texture0Arb = unchecked((uint)0x84C0),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_TEXTURE1_ARB")]
    Texture1Arb = unchecked((uint)0x84C1),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PRIMARY_COLOR_NV")]
    PrimaryColornv = unchecked((uint)0x852C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SECONDARY_COLOR_NV")]
    SecondaryColornv = unchecked((uint)0x852D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SPARE0_NV")]
    Spare0Nv = unchecked((uint)0x852E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SPARE1_NV")]
    Spare1Nv = unchecked((uint)0x852F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DISCARD_NV")]
    Discardnv = unchecked((uint)0x8530),
}
