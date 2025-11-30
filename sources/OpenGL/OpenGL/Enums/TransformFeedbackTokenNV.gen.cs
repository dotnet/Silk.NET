// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "NV", 0)]
[NativeName("TransformFeedbackTokenNV")]
[Transformed]
public enum TransformFeedbackTokenNV : uint
{
    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_NEXT_BUFFER_NV")]
    NextBufferNV = unchecked((uint)-2),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SKIP_COMPONENTS4_NV")]
    SkipComponents4NV = unchecked((uint)-3),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SKIP_COMPONENTS3_NV")]
    SkipComponents3NV = unchecked((uint)-4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SKIP_COMPONENTS2_NV")]
    SkipComponents2NV = unchecked((uint)-5),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SKIP_COMPONENTS1_NV")]
    SkipComponents1NV = unchecked((uint)-6),
}
