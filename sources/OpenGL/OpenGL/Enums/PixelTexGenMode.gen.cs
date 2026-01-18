// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PixelTexGenModeSGIX")]
public enum PixelTexGenMode : uint
{
    [NativeName("GL_NONE")]
    None = 0,

    [NativeName("GL_ALPHA")]
    Alpha = 6406,

    [NativeName("GL_RGB")]
    Rgb = 6407,

    [NativeName("GL_RGBA")]
    Rgba = 6408,
}
