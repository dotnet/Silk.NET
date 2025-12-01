// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("GraphicsResetStatus")]
public enum GraphicsResetStatus : uint
{
    [NativeName("GL_NO_ERROR")]
    NoError = unchecked((uint)0),

    [NativeName("GL_GUILTY_CONTEXT_RESET")]
    GuiltyContextReset = unchecked((uint)0x8253),

    [NativeName("GL_INNOCENT_CONTEXT_RESET")]
    InnocentContextReset = unchecked((uint)0x8254),

    [NativeName("GL_UNKNOWN_CONTEXT_RESET")]
    UnknownContextReset = unchecked((uint)0x8255),
}
