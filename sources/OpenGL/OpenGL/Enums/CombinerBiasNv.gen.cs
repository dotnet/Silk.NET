// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "NV", 0)]
[NativeName("CombinerBiasNV")]
[Transformed]
public enum CombinerBiasNv : uint
{
    [NativeName("GL_NONE")]
    None = unchecked((uint)0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_BIAS_BY_NEGATIVE_ONE_HALF_NV")]
    BiasByNegativeOneHalfnv = unchecked((uint)0x8541),
}
