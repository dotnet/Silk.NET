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
    ColorTable = unchecked((uint)0x80D0),

    [NativeName("GL_POST_CONVOLUTION_COLOR_TABLE")]
    PostConvolutionColorTable = unchecked((uint)0x80D1),

    [NativeName("GL_POST_COLOR_MATRIX_COLOR_TABLE")]
    PostColorMatrixColorTable = unchecked((uint)0x80D2),

    [NativeName("GL_PROXY_COLOR_TABLE")]
    ProxyColorTable = unchecked((uint)0x80D3),

    [NativeName("GL_PROXY_POST_CONVOLUTION_COLOR_TABLE")]
    ProxyPostConvolutionColorTable = unchecked((uint)0x80D4),

    [NativeName("GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE")]
    ProxyPostColorMatrixColorTable = unchecked((uint)0x80D5),

    [NativeName("GL_COLOR_TABLE_SGI")]
    ColorTableSGI = unchecked((uint)0x80D0),

    [NativeName("GL_POST_CONVOLUTION_COLOR_TABLE_SGI")]
    PostConvolutionColorTableSGI = unchecked((uint)0x80D1),

    [NativeName("GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI")]
    PostColorMatrixColorTableSGI = unchecked((uint)0x80D2),

    [NativeName("GL_PROXY_COLOR_TABLE_SGI")]
    ProxyColorTableSGI = unchecked((uint)0x80D3),

    [NativeName("GL_PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI")]
    ProxyPostConvolutionColorTableSGI = unchecked((uint)0x80D4),

    [NativeName("GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI")]
    ProxyPostColorMatrixColorTableSGI = unchecked((uint)0x80D5),

    [NativeName("GL_TEXTURE_COLOR_TABLE_SGI")]
    TextureColorTableSGI = unchecked((uint)0x80BC),

    [NativeName("GL_PROXY_TEXTURE_COLOR_TABLE_SGI")]
    ProxyTextureColorTableSGI = unchecked((uint)0x80BD),
}
