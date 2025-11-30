// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FogCoordSrc")]
[Transformed]
public enum FogCoordSrc : uint
{
    [NativeName("GL_FOG_COORDINATE")]
    FogCoordinate = unchecked((uint)0x8451),

    [NativeName("GL_FRAGMENT_DEPTH")]
    FragmentDepth = unchecked((uint)0x8452),

    [NativeName("GL_FOG_COORD")]
    FogCoord = unchecked((uint)0x8451),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FOG_COORDINATE_EXT")]
    FogCoordinateext = unchecked((uint)0x8451),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_DEPTH_EXT")]
    FragmentDepthext = unchecked((uint)0x8452),
}
