// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ColorTableTargetSGI")]
public enum ColorTableTargetSGI : uint
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

    [NativeName("GL_COLOR_TABLE_SGI")]
    ColorTableSGI = 32976,

    [NativeName("GL_POST_CONVOLUTION_COLOR_TABLE_SGI")]
    PostConvolutionColorTableSGI = 32977,

    [NativeName("GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI")]
    PostColorMatrixColorTableSGI = 32978,

    [NativeName("GL_PROXY_COLOR_TABLE_SGI")]
    ProxyColorTableSGI = 32979,

    [NativeName("GL_PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI")]
    ProxyPostConvolutionColorTableSGI = 32980,

    [NativeName("GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI")]
    ProxyPostColorMatrixColorTableSGI = 32981,

    [NativeName("GL_TEXTURE_COLOR_TABLE_SGI")]
    TextureColorTableSGI = 32956,

    [NativeName("GL_PROXY_TEXTURE_COLOR_TABLE_SGI")]
    ProxyTextureColorTableSGI = 32957,
}
