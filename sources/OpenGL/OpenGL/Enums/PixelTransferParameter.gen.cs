// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PixelTransferParameter")]
public enum PixelTransferParameter : uint
{
    [NativeName("GL_ALPHA_SCALE")]
    AlphaScale = 3356,

    [NativeName("GL_MAP_COLOR")]
    MapColor = 3344,

    [NativeName("GL_MAP_STENCIL")]
    MapStencil = 3345,

    [NativeName("GL_INDEX_SHIFT")]
    IndexShift = 3346,

    [NativeName("GL_INDEX_OFFSET")]
    IndexOffset = 3347,

    [NativeName("GL_RED_SCALE")]
    RedScale = 3348,

    [NativeName("GL_RED_BIAS")]
    RedBias = 3349,

    [NativeName("GL_GREEN_SCALE")]
    GreenScale = 3352,

    [NativeName("GL_GREEN_BIAS")]
    GreenBias = 3353,

    [NativeName("GL_BLUE_SCALE")]
    BlueScale = 3354,

    [NativeName("GL_BLUE_BIAS")]
    BlueBias = 3355,

    [NativeName("GL_ALPHA_BIAS")]
    AlphaBias = 3357,

    [NativeName("GL_DEPTH_SCALE")]
    DepthScale = 3358,

    [NativeName("GL_DEPTH_BIAS")]
    DepthBias = 3359,

    [NativeName("GL_POST_CONVOLUTION_RED_SCALE")]
    PostConvolutionRedScale = 32796,

    [NativeName("GL_POST_CONVOLUTION_GREEN_SCALE")]
    PostConvolutionGreenScale = 32797,

    [NativeName("GL_POST_CONVOLUTION_BLUE_SCALE")]
    PostConvolutionBlueScale = 32798,

    [NativeName("GL_POST_CONVOLUTION_ALPHA_SCALE")]
    PostConvolutionAlphaScale = 32799,

    [NativeName("GL_POST_CONVOLUTION_RED_BIAS")]
    PostConvolutionRedBias = 32800,

    [NativeName("GL_POST_CONVOLUTION_GREEN_BIAS")]
    PostConvolutionGreenBias = 32801,

    [NativeName("GL_POST_CONVOLUTION_BLUE_BIAS")]
    PostConvolutionBlueBias = 32802,

    [NativeName("GL_POST_CONVOLUTION_ALPHA_BIAS")]
    PostConvolutionAlphaBias = 32803,

    [NativeName("GL_POST_COLOR_MATRIX_RED_SCALE")]
    PostColorMatrixRedScale = 32948,

    [NativeName("GL_POST_COLOR_MATRIX_GREEN_SCALE")]
    PostColorMatrixGreenScale = 32949,

    [NativeName("GL_POST_COLOR_MATRIX_BLUE_SCALE")]
    PostColorMatrixBlueScale = 32950,

    [NativeName("GL_POST_COLOR_MATRIX_ALPHA_SCALE")]
    PostColorMatrixAlphaScale = 32951,

    [NativeName("GL_POST_COLOR_MATRIX_RED_BIAS")]
    PostColorMatrixRedBias = 32952,

    [NativeName("GL_POST_COLOR_MATRIX_GREEN_BIAS")]
    PostColorMatrixGreenBias = 32953,

    [NativeName("GL_POST_COLOR_MATRIX_BLUE_BIAS")]
    PostColorMatrixBlueBias = 32954,

    [NativeName("GL_POST_COLOR_MATRIX_ALPHA_BIAS")]
    PostColorMatrixAlphaBias = 32955,

    [NativeName("GL_POST_CONVOLUTION_RED_SCALE_EXT")]
    PostConvolutionRedScaleEXT = 32796,

    [NativeName("GL_POST_CONVOLUTION_GREEN_SCALE_EXT")]
    PostConvolutionGreenScaleEXT = 32797,

    [NativeName("GL_POST_CONVOLUTION_BLUE_SCALE_EXT")]
    PostConvolutionBlueScaleEXT = 32798,

    [NativeName("GL_POST_CONVOLUTION_ALPHA_SCALE_EXT")]
    PostConvolutionAlphaScaleEXT = 32799,

    [NativeName("GL_POST_CONVOLUTION_RED_BIAS_EXT")]
    PostConvolutionRedBiasEXT = 32800,

    [NativeName("GL_POST_CONVOLUTION_GREEN_BIAS_EXT")]
    PostConvolutionGreenBiasEXT = 32801,

    [NativeName("GL_POST_CONVOLUTION_BLUE_BIAS_EXT")]
    PostConvolutionBlueBiasEXT = 32802,

    [NativeName("GL_POST_CONVOLUTION_ALPHA_BIAS_EXT")]
    PostConvolutionAlphaBiasEXT = 32803,

    [NativeName("GL_POST_COLOR_MATRIX_RED_SCALE_SGI")]
    PostColorMatrixRedScaleSGI = 32948,

    [NativeName("GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI")]
    PostColorMatrixGreenScaleSGI = 32949,

    [NativeName("GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI")]
    PostColorMatrixBlueScaleSGI = 32950,

    [NativeName("GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI")]
    PostColorMatrixAlphaScaleSGI = 32951,

    [NativeName("GL_POST_COLOR_MATRIX_RED_BIAS_SGI")]
    PostColorMatrixRedBiasSGI = 32952,

    [NativeName("GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI")]
    PostColorMatrixGreenBiasSGI = 32953,

    [NativeName("GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI")]
    PostColorMatrixBlueBiasSGI = 32954,

    [NativeName("GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI")]
    PostColorMatrixAlphaBiasSGI = 32955,
}
