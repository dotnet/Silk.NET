// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("VertexShaderCoordOutEXT")]
public enum VertexShaderCoordOutEXT : uint
{
    [NativeName("GL_X_EXT")]
    X = 34773,

    [NativeName("GL_Y_EXT")]
    Y = 34774,

    [NativeName("GL_Z_EXT")]
    Z = 34775,

    [NativeName("GL_W_EXT")]
    W = 34776,

    [NativeName("GL_NEGATIVE_X_EXT")]
    NegativeX = 34777,

    [NativeName("GL_NEGATIVE_Y_EXT")]
    NegativeY = 34778,

    [NativeName("GL_NEGATIVE_Z_EXT")]
    NegativeZ = 34779,

    [NativeName("GL_NEGATIVE_W_EXT")]
    NegativeW = 34780,

    [NativeName("GL_ZERO_EXT")]
    Zero = 34781,

    [NativeName("GL_ONE_EXT")]
    One = 34782,

    [NativeName("GL_NEGATIVE_ONE_EXT")]
    NegativeOne = 34783,
}
