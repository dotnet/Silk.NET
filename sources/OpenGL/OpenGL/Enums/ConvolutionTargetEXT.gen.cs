// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("ConvolutionTargetEXT")]
[Transformed]
public enum ConvolutionTargetEXT : uint
{
    [NativeName("GL_CONVOLUTION_1D")]
    Convolution1D = unchecked((uint)0x8010),

    [NativeName("GL_CONVOLUTION_2D")]
    Convolution2D = unchecked((uint)0x8011),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONVOLUTION_1D_EXT")]
    Convolution1DEXT = unchecked((uint)0x8010),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONVOLUTION_2D_EXT")]
    Convolution2DEXT = unchecked((uint)0x8011),
}
