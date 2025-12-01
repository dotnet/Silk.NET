// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TransformFeedbackBufferMode")]
public enum TransformFeedbackBufferMode : uint
{
    [NativeName("GL_INTERLEAVED_ATTRIBS")]
    InterleavedAttribs = unchecked((uint)0x8C8C),

    [NativeName("GL_SEPARATE_ATTRIBS")]
    SeparateAttribs = unchecked((uint)0x8C8D),
}
