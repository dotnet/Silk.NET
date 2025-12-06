// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("SamplePatternSGIS")]
public enum SamplePatternSGIS : uint
{
    [NativeName("GL_1PASS_EXT")]
    X1PassEXT = 32929,

    [NativeName("GL_2PASS_0_EXT")]
    X2Pass0EXT = 32930,

    [NativeName("GL_2PASS_1_EXT")]
    X2Pass1EXT = 32931,

    [NativeName("GL_4PASS_0_EXT")]
    X4Pass0EXT = 32932,

    [NativeName("GL_4PASS_1_EXT")]
    X4Pass1EXT = 32933,

    [NativeName("GL_4PASS_2_EXT")]
    X4Pass2EXT = 32934,

    [NativeName("GL_4PASS_3_EXT")]
    X4Pass3EXT = 32935,

    [NativeName("GL_1PASS_SGIS")]
    X1Pass = 32929,

    [NativeName("GL_2PASS_0_SGIS")]
    X2Pass0 = 32930,

    [NativeName("GL_2PASS_1_SGIS")]
    X2Pass1 = 32931,

    [NativeName("GL_4PASS_0_SGIS")]
    X4Pass0 = 32932,

    [NativeName("GL_4PASS_1_SGIS")]
    X4Pass1 = 32933,

    [NativeName("GL_4PASS_2_SGIS")]
    X4Pass2 = 32934,

    [NativeName("GL_4PASS_3_SGIS")]
    X4Pass3 = 32935,
}
