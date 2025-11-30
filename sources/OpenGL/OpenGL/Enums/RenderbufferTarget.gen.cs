// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("RenderbufferTarget")]
[Transformed]
public enum RenderbufferTarget : uint
{
    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RENDERBUFFER_OES")]
    RenderbufferOES = unchecked((uint)0x8D41),

    [NativeName("GL_RENDERBUFFER")]
    Renderbuffer = unchecked((uint)0x8D41),
}
