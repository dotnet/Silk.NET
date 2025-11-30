// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "SUN", 0)]
[NativeName("TriangleListSUN")]
[Transformed]
public enum TriangleListSUN : uint
{
    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_RESTART_SUN")]
    RestartSUN = unchecked((uint)0x0001),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_REPLACE_MIDDLE_SUN")]
    ReplaceMiddleSUN = unchecked((uint)0x0002),

    [NameAffix("Suffix", "SUN", 0)]
    [NativeName("GL_REPLACE_OLDEST_SUN")]
    ReplaceOldestSUN = unchecked((uint)0x0003),
}
