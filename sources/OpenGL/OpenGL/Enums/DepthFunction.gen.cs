// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("DepthFunction")]
public enum DepthFunction : uint
{
    [NativeName("GL_NEVER")]
    Never = 512,

    [NativeName("GL_LESS")]
    Less = 513,

    [NativeName("GL_EQUAL")]
    Equal = 514,

    [NativeName("GL_LEQUAL")]
    Lequal = 515,

    [NativeName("GL_GREATER")]
    Greater = 516,

    [NativeName("GL_NOTEQUAL")]
    Notequal = 517,

    [NativeName("GL_GEQUAL")]
    Gequal = 518,

    [NativeName("GL_ALWAYS")]
    Always = 519,
}
