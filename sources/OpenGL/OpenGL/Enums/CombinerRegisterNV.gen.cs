// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("CombinerRegisterNV")]
public enum CombinerRegisterNV : uint
{
    [NativeName("GL_TEXTURE0_ARB")]
    Texture0ARB = unchecked((uint)0x84C0),

    [NativeName("GL_TEXTURE1_ARB")]
    Texture1ARB = unchecked((uint)0x84C1),

    [NativeName("GL_PRIMARY_COLOR_NV")]
    PrimaryColorNV = unchecked((uint)0x852C),

    [NativeName("GL_SECONDARY_COLOR_NV")]
    SecondaryColorNV = unchecked((uint)0x852D),

    [NativeName("GL_SPARE0_NV")]
    Spare0NV = unchecked((uint)0x852E),

    [NativeName("GL_SPARE1_NV")]
    Spare1NV = unchecked((uint)0x852F),

    [NativeName("GL_DISCARD_NV")]
    DiscardNV = unchecked((uint)0x8530),
}
