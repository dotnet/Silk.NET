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
    Nearest = unchecked((uint)0x2600),

    [NativeName("GL_LINEAR")]
    Linear = unchecked((uint)0x2601),

    [NativeName("GL_NEAREST_MIPMAP_NEAREST")]
    NearestMipmapNearest = unchecked((uint)0x2700),

    [NativeName("GL_LINEAR_MIPMAP_NEAREST")]
    LinearMipmapNearest = unchecked((uint)0x2701),

    [NativeName("GL_NEAREST_MIPMAP_LINEAR")]
    NearestMipmapLinear = unchecked((uint)0x2702),

    [NativeName("GL_LINEAR_MIPMAP_LINEAR")]
    LinearMipmapLinear = unchecked((uint)0x2703),

    [NativeName("GL_FILTER4_SGIS")]
    Filter4SGIS = unchecked((uint)0x8146),

    [NativeName("GL_LINEAR_CLIPMAP_LINEAR_SGIX")]
    LinearClipmapLinearSGIX = unchecked((uint)0x8170),

    [NativeName("GL_NEAREST_CLIPMAP_NEAREST_SGIX")]
    NearestClipmapNearestSGIX = unchecked((uint)0x844D),

    [NativeName("GL_NEAREST_CLIPMAP_LINEAR_SGIX")]
    NearestClipmapLinearSGIX = unchecked((uint)0x844E),

    [NativeName("GL_LINEAR_CLIPMAP_NEAREST_SGIX")]
    LinearClipmapNearestSGIX = unchecked((uint)0x844F),
}
