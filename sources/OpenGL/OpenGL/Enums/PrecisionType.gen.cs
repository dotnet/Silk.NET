// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PrecisionType")]
public enum PrecisionType : uint
{
    [NativeName("GL_LOW_FLOAT")]
    LowFloat = 36336,

    [NativeName("GL_MEDIUM_FLOAT")]
    MediumFloat = 36337,

    [NativeName("GL_HIGH_FLOAT")]
    HighFloat = 36338,

    [NativeName("GL_LOW_INT")]
    LowInt = 36339,

    [NativeName("GL_MEDIUM_INT")]
    MediumInt = 36340,

    [NativeName("GL_HIGH_INT")]
    HighInt = 36341,
}
