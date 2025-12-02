// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("InstancedPathCoverMode")]
public enum InstancedPathCoverMode : uint
{
    [NativeName("GL_PATH_FILL_COVER_MODE_NV")]
    PathFillCoverModeNV = unchecked((uint)0x9082),

    [NativeName("GL_CONVEX_HULL_NV")]
    ConvexHullNV = unchecked((uint)0x908B),

    [NativeName("GL_BOUNDING_BOX_NV")]
    BoundingBoxNV = unchecked((uint)0x908D),

    [NativeName("GL_BOUNDING_BOX_OF_BOUNDING_BOXES_NV")]
    BoundingBoxOfBoundingBoxesNV = unchecked((uint)0x909C),
}
