// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureMinFilter")]
public enum TextureMinFilter : uint
{
    [NativeName("GL_NEAREST")]
    Nearest = 9728,

    [NativeName("GL_LINEAR")]
    Linear = 9729,

    [NativeName("GL_NEAREST_MIPMAP_NEAREST")]
    NearestMipmapNearest = 9984,

    [NativeName("GL_LINEAR_MIPMAP_NEAREST")]
    LinearMipmapNearest = 9985,

    [NativeName("GL_NEAREST_MIPMAP_LINEAR")]
    NearestMipmapLinear = 9986,

    [NativeName("GL_LINEAR_MIPMAP_LINEAR")]
    LinearMipmapLinear = 9987,

    [NativeName("GL_FILTER4_SGIS")]
    Filter4SGIS = 33094,

    [NativeName("GL_LINEAR_CLIPMAP_LINEAR_SGIX")]
    LinearClipmapLinearSGIX = 33136,

    [NativeName("GL_NEAREST_CLIPMAP_NEAREST_SGIX")]
    NearestClipmapNearestSGIX = 33869,

    [NativeName("GL_NEAREST_CLIPMAP_LINEAR_SGIX")]
    NearestClipmapLinearSGIX = 33870,

    [NativeName("GL_LINEAR_CLIPMAP_NEAREST_SGIX")]
    LinearClipmapNearestSGIX = 33871,
}
