// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PixelTransferParameter")]
[Transformed]
public enum PixelTransferParameter : uint
{
    [NativeName("GL_ALPHA_SCALE")]
    AlphaScale = unchecked((uint)0x0D1C),

    [NativeName("GL_MAP_COLOR")]
    MapColor = unchecked((uint)0x0D10),

    [NativeName("GL_MAP_STENCIL")]
    MapStencil = unchecked((uint)0x0D11),

    [NativeName("GL_INDEX_SHIFT")]
    IndexShift = unchecked((uint)0x0D12),

    [NativeName("GL_INDEX_OFFSET")]
    IndexOffset = unchecked((uint)0x0D13),

    [NativeName("GL_RED_SCALE")]
    RedScale = unchecked((uint)0x0D14),

    [NativeName("GL_RED_BIAS")]
    RedBias = unchecked((uint)0x0D15),

    [NativeName("GL_GREEN_SCALE")]
    GreenScale = unchecked((uint)0x0D18),

    [NativeName("GL_GREEN_BIAS")]
    GreenBias = unchecked((uint)0x0D19),

    [NativeName("GL_BLUE_SCALE")]
    BlueScale = unchecked((uint)0x0D1A),

    [NativeName("GL_BLUE_BIAS")]
    BlueBias = unchecked((uint)0x0D1B),

    [NativeName("GL_ALPHA_BIAS")]
    AlphaBias = unchecked((uint)0x0D1D),

    [NativeName("GL_DEPTH_SCALE")]
    DepthScale = unchecked((uint)0x0D1E),

    [NativeName("GL_DEPTH_BIAS")]
    DepthBias = unchecked((uint)0x0D1F),

    [NativeName("GL_POST_CONVOLUTION_RED_SCALE")]
    PostConvolutionRedScale = unchecked((uint)0x801C),

    [NativeName("GL_POST_CONVOLUTION_GREEN_SCALE")]
    PostConvolutionGreenScale = unchecked((uint)0x801D),

    [NativeName("GL_POST_CONVOLUTION_BLUE_SCALE")]
    PostConvolutionBlueScale = unchecked((uint)0x801E),

    [NativeName("GL_POST_CONVOLUTION_ALPHA_SCALE")]
    PostConvolutionAlphaScale = unchecked((uint)0x801F),

    [NativeName("GL_POST_CONVOLUTION_RED_BIAS")]
    PostConvolutionRedBias = unchecked((uint)0x8020),

    [NativeName("GL_POST_CONVOLUTION_GREEN_BIAS")]
    PostConvolutionGreenBias = unchecked((uint)0x8021),

    [NativeName("GL_POST_CONVOLUTION_BLUE_BIAS")]
    PostConvolutionBlueBias = unchecked((uint)0x8022),

    [NativeName("GL_POST_CONVOLUTION_ALPHA_BIAS")]
    PostConvolutionAlphaBias = unchecked((uint)0x8023),

    [NativeName("GL_POST_COLOR_MATRIX_RED_SCALE")]
    PostColorMatrixRedScale = unchecked((uint)0x80B4),

    [NativeName("GL_POST_COLOR_MATRIX_GREEN_SCALE")]
    PostColorMatrixGreenScale = unchecked((uint)0x80B5),

    [NativeName("GL_POST_COLOR_MATRIX_BLUE_SCALE")]
    PostColorMatrixBlueScale = unchecked((uint)0x80B6),

    [NativeName("GL_POST_COLOR_MATRIX_ALPHA_SCALE")]
    PostColorMatrixAlphaScale = unchecked((uint)0x80B7),

    [NativeName("GL_POST_COLOR_MATRIX_RED_BIAS")]
    PostColorMatrixRedBias = unchecked((uint)0x80B8),

    [NativeName("GL_POST_COLOR_MATRIX_GREEN_BIAS")]
    PostColorMatrixGreenBias = unchecked((uint)0x80B9),

    [NativeName("GL_POST_COLOR_MATRIX_BLUE_BIAS")]
    PostColorMatrixBlueBias = unchecked((uint)0x80BA),

    [NativeName("GL_POST_COLOR_MATRIX_ALPHA_BIAS")]
    PostColorMatrixAlphaBias = unchecked((uint)0x80BB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POST_CONVOLUTION_RED_SCALE_EXT")]
    PostConvolutionRedScaleext = unchecked((uint)0x801C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POST_CONVOLUTION_GREEN_SCALE_EXT")]
    PostConvolutionGreenScaleext = unchecked((uint)0x801D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POST_CONVOLUTION_BLUE_SCALE_EXT")]
    PostConvolutionBlueScaleext = unchecked((uint)0x801E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POST_CONVOLUTION_ALPHA_SCALE_EXT")]
    PostConvolutionAlphaScaleext = unchecked((uint)0x801F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POST_CONVOLUTION_RED_BIAS_EXT")]
    PostConvolutionRedBiasext = unchecked((uint)0x8020),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POST_CONVOLUTION_GREEN_BIAS_EXT")]
    PostConvolutionGreenBiasext = unchecked((uint)0x8021),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POST_CONVOLUTION_BLUE_BIAS_EXT")]
    PostConvolutionBlueBiasext = unchecked((uint)0x8022),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_POST_CONVOLUTION_ALPHA_BIAS_EXT")]
    PostConvolutionAlphaBiasext = unchecked((uint)0x8023),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_POST_COLOR_MATRIX_RED_SCALE_SGI")]
    PostColorMatrixRedScalesgi = unchecked((uint)0x80B4),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI")]
    PostColorMatrixGreenScalesgi = unchecked((uint)0x80B5),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI")]
    PostColorMatrixBlueScalesgi = unchecked((uint)0x80B6),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI")]
    PostColorMatrixAlphaScalesgi = unchecked((uint)0x80B7),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_POST_COLOR_MATRIX_RED_BIAS_SGI")]
    PostColorMatrixRedBiassgi = unchecked((uint)0x80B8),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI")]
    PostColorMatrixGreenBiassgi = unchecked((uint)0x80B9),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI")]
    PostColorMatrixBlueBiassgi = unchecked((uint)0x80BA),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI")]
    PostColorMatrixAlphaBiassgi = unchecked((uint)0x80BB),
}
