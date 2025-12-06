// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FogCoordSrc")]
public enum FogCoordSrc : uint
{
    [NativeName("GL_FOG_COORDINATE")]
    FogCoordinate = 33873,

    [NativeName("GL_FRAGMENT_DEPTH")]
    FragmentDepth = 33874,

    [NativeName("GL_FOG_COORD")]
    FogCoord = 33873,

    [NativeName("GL_FOG_COORDINATE_EXT")]
    FogCoordinateEXT = 33873,

    [NativeName("GL_FRAGMENT_DEPTH_EXT")]
    FragmentDepthEXT = 33874,
}
