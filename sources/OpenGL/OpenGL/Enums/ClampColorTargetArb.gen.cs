// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "ARB", 0)]
[NativeName("ClampColorTargetARB")]
[Transformed]
public enum ClampColorTargetArb : uint
{
    [NativeName("GL_CLAMP_READ_COLOR")]
    ReadColor = unchecked((uint)0x891C),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_CLAMP_VERTEX_COLOR_ARB")]
    VertexColorarb = unchecked((uint)0x891A),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_CLAMP_FRAGMENT_COLOR_ARB")]
    FragmentColorarb = unchecked((uint)0x891B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_CLAMP_READ_COLOR_ARB")]
    ReadColorarb = unchecked((uint)0x891C),
}
