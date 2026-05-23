// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ColorTableTarget")]
public enum ColorTableTarget : uint
{
    [NativeName("GL_COLOR_TABLE")]
    ColorTable = 32976,

    [NativeName("GL_POST_CONVOLUTION_COLOR_TABLE")]
    PostConvolutionColorTable = 32977,

    [NativeName("GL_POST_COLOR_MATRIX_COLOR_TABLE")]
    PostColorMatrixColorTable = 32978,

    [NativeName("GL_PROXY_COLOR_TABLE")]
    ProxyColorTable = 32979,

    [NativeName("GL_PROXY_POST_CONVOLUTION_COLOR_TABLE")]
    ProxyPostConvolutionColorTable = 32980,

    [NativeName("GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE")]
    ProxyPostColorMatrixColorTable = 32981,
}
