// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "ATI", 0)]
[NativeName("GetTexBumpParameterATI")]
[Transformed]
public enum GetTexBumpParameterATI : uint
{
    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_BUMP_ROT_MATRIX_ATI")]
    RotMatrixATI = unchecked((uint)0x8775),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_BUMP_ROT_MATRIX_SIZE_ATI")]
    RotMatrixSizeATI = unchecked((uint)0x8776),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_BUMP_NUM_TEX_UNITS_ATI")]
    NumTexUnitsATI = unchecked((uint)0x8777),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_BUMP_TEX_UNITS_ATI")]
    TexUnitsATI = unchecked((uint)0x8778),
}
