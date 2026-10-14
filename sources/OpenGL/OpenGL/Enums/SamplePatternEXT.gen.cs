// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("SamplePatternEXT")]
public enum SamplePatternEXT : uint
{
    [NativeName("GL_1PASS_EXT")]
    X1Pass = 32929,

    [NativeName("GL_2PASS_0_EXT")]
    X2Pass0 = 32930,

    [NativeName("GL_2PASS_1_EXT")]
    X2Pass1 = 32931,

    [NativeName("GL_4PASS_0_EXT")]
    X4Pass0 = 32932,

    [NativeName("GL_4PASS_1_EXT")]
    X4Pass1 = 32933,

    [NativeName("GL_4PASS_2_EXT")]
    X4Pass2 = 32934,

    [NativeName("GL_4PASS_3_EXT")]
    X4Pass3 = 32935,
}
