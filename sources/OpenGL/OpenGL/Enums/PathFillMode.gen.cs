// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PathFillMode")]
public enum PathFillMode : uint
{
    [NativeName("GL_INVERT")]
    Invert = 5386,

    [NativeName("GL_PATH_FILL_MODE_NV")]
    PathFillModeNV = 36992,

    [NativeName("GL_COUNT_UP_NV")]
    CountUpNV = 37000,

    [NativeName("GL_COUNT_DOWN_NV")]
    CountDownNV = 37001,
}
