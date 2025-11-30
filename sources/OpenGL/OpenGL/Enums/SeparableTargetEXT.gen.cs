// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("SeparableTargetEXT")]
[Transformed]
public enum SeparableTargetEXT : uint
{
    [NativeName("GL_SEPARABLE_2D")]
    Separable2D = unchecked((uint)0x8012),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SEPARABLE_2D_EXT")]
    Separable2DEXT = unchecked((uint)0x8012),
}
