// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PrecisionType")]
[Transformed]
public enum PrecisionType : uint
{
    [NativeName("GL_LOW_FLOAT")]
    LowFloat = unchecked((uint)0x8DF0),

    [NativeName("GL_MEDIUM_FLOAT")]
    MediumFloat = unchecked((uint)0x8DF1),

    [NativeName("GL_HIGH_FLOAT")]
    HighFloat = unchecked((uint)0x8DF2),

    [NativeName("GL_LOW_INT")]
    LowInt = unchecked((uint)0x8DF3),

    [NativeName("GL_MEDIUM_INT")]
    MediumInt = unchecked((uint)0x8DF4),

    [NativeName("GL_HIGH_INT")]
    HighInt = unchecked((uint)0x8DF5),
}
