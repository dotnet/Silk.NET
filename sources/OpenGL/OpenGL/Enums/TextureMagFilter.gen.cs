// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureMagFilter")]
public enum TextureMagFilter : uint
{
    [NativeName("GL_NEAREST")]
    Nearest = 9728,

    [NativeName("GL_LINEAR")]
    Linear = 9729,

    [NativeName("GL_LINEAR_DETAIL_SGIS")]
    LinearDetailSGIS = 32919,

    [NativeName("GL_LINEAR_DETAIL_ALPHA_SGIS")]
    LinearDetailAlphaSGIS = 32920,

    [NativeName("GL_LINEAR_DETAIL_COLOR_SGIS")]
    LinearDetailColorSGIS = 32921,

    [NativeName("GL_LINEAR_SHARPEN_SGIS")]
    LinearSharpenSGIS = 32941,

    [NativeName("GL_LINEAR_SHARPEN_ALPHA_SGIS")]
    LinearSharpenAlphaSGIS = 32942,

    [NativeName("GL_LINEAR_SHARPEN_COLOR_SGIS")]
    LinearSharpenColorSGIS = 32943,

    [NativeName("GL_FILTER4_SGIS")]
    Filter4SGIS = 33094,
}
