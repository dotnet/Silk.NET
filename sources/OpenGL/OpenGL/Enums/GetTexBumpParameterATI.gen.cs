// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("GetTexBumpParameterATI")]
public enum GetTexBumpParameterATI : uint
{
    [NativeName("GL_BUMP_ROT_MATRIX_ATI")]
    RotMatrix = 34677,

    [NativeName("GL_BUMP_ROT_MATRIX_SIZE_ATI")]
    RotMatrixSize = 34678,

    [NativeName("GL_BUMP_NUM_TEX_UNITS_ATI")]
    NumTexUnits = 34679,

    [NativeName("GL_BUMP_TEX_UNITS_ATI")]
    TexUnits = 34680,
}
