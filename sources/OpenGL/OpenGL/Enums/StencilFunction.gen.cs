// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("StencilFunction")]
[Transformed]
public enum StencilFunction : uint
{
    [NativeName("GL_NEVER")]
    Never = unchecked((uint)0x0200),

    [NativeName("GL_LESS")]
    Less = unchecked((uint)0x0201),

    [NativeName("GL_EQUAL")]
    Equal = unchecked((uint)0x0202),

    [NativeName("GL_LEQUAL")]
    Lequal = unchecked((uint)0x0203),

    [NativeName("GL_GREATER")]
    Greater = unchecked((uint)0x0204),

    [NativeName("GL_NOTEQUAL")]
    Notequal = unchecked((uint)0x0205),

    [NativeName("GL_GEQUAL")]
    Gequal = unchecked((uint)0x0206),

    [NativeName("GL_ALWAYS")]
    Always = unchecked((uint)0x0207),
}
