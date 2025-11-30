// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PathColor")]
[Transformed]
public enum PathColor : uint
{
    [NativeName("GL_PRIMARY_COLOR")]
    PrimaryColor = unchecked((uint)0x8577),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PRIMARY_COLOR_NV")]
    PrimaryColornv = unchecked((uint)0x852C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SECONDARY_COLOR_NV")]
    SecondaryColornv = unchecked((uint)0x852D),
}
