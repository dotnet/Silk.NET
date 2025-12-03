// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("CombinerBiasNV")]
public enum CombinerBias : uint
{
    [NativeName("GL_NONE")]
    None = 0,

    [NativeName("GL_BIAS_BY_NEGATIVE_ONE_HALF_NV")]
    BiasByNegativeOneHalfNV = 34113,
}
