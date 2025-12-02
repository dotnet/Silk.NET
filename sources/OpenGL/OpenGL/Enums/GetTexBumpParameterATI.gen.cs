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
    RotMatrix = unchecked((uint)0x8775),

    [NativeName("GL_BUMP_ROT_MATRIX_SIZE_ATI")]
    RotMatrixSize = unchecked((uint)0x8776),

    [NativeName("GL_BUMP_NUM_TEX_UNITS_ATI")]
    NumTexUnits = unchecked((uint)0x8777),

    [NativeName("GL_BUMP_TEX_UNITS_ATI")]
    TexUnits = unchecked((uint)0x8778),
}
