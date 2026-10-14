// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("Buffer")]
public enum Buffer : uint
{
    [NativeName("GL_COLOR")]
    Color = 6144,

    [NativeName("GL_DEPTH")]
    Depth = 6145,

    [NativeName("GL_STENCIL")]
    Stencil = 6146,
}
