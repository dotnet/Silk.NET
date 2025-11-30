// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("InstancedPathCoverMode")]
[Transformed]
public enum InstancedPathCoverMode : uint
{
    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_FILL_COVER_MODE_NV")]
    PathFillCoverModenv = unchecked((uint)0x9082),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CONVEX_HULL_NV")]
    ConvexHullnv = unchecked((uint)0x908B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_BOUNDING_BOX_NV")]
    BoundingBoxnv = unchecked((uint)0x908D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_BOUNDING_BOX_OF_BOUNDING_BOXES_NV")]
    BoundingBoxOfBoundingBoxesnv = unchecked((uint)0x909C),
}
