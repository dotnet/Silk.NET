// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PathFillMode")]
[Transformed]
public enum PathFillMode : uint
{
    [NativeName("GL_INVERT")]
    Invert = unchecked((uint)0x150A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_FILL_MODE_NV")]
    PathFillModenv = unchecked((uint)0x9080),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COUNT_UP_NV")]
    CountUpnv = unchecked((uint)0x9088),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COUNT_DOWN_NV")]
    CountDownnv = unchecked((uint)0x9089),
}
