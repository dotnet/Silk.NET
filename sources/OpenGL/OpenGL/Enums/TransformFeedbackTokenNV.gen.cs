// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TransformFeedbackTokenNV")]
public enum TransformFeedbackTokenNV : uint
{
    [NativeName("GL_NEXT_BUFFER_NV")]
    NextBuffer = unchecked((uint)-2),

    [NativeName("GL_SKIP_COMPONENTS4_NV")]
    SkipComponents4 = unchecked((uint)-3),

    [NativeName("GL_SKIP_COMPONENTS3_NV")]
    SkipComponents3 = unchecked((uint)-4),

    [NativeName("GL_SKIP_COMPONENTS2_NV")]
    SkipComponents2 = unchecked((uint)-5),

    [NativeName("GL_SKIP_COMPONENTS1_NV")]
    SkipComponents1 = unchecked((uint)-6),
}
