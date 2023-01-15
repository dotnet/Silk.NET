// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "PixelTransferParameter")]
    public enum PixelTransferParameter : int
    {
        [Obsolete("Deprecated in favour of \"ConvolutionRedScale\"")]
        [NativeName("Name", "GL_POST_CONVOLUTION_RED_SCALE")]
        PostConvolutionRedScale = 0x801C,
        [Obsolete("Deprecated in favour of \"ConvolutionRedScaleExt\"")]
        [NativeName("Name", "GL_POST_CONVOLUTION_RED_SCALE_EXT")]
        PostConvolutionRedScaleExt = 0x801C,
        [Obsolete("Deprecated in favour of \"ConvolutionGreenScale\"")]
        [NativeName("Name", "GL_POST_CONVOLUTION_GREEN_SCALE")]
        PostConvolutionGreenScale = 0x801D,
        [Obsolete("Deprecated in favour of \"ConvolutionGreenScaleExt\"")]
        [NativeName("Name", "GL_POST_CONVOLUTION_GREEN_SCALE_EXT")]
        PostConvolutionGreenScaleExt = 0x801D,
        [Obsolete("Deprecated in favour of \"ConvolutionBlueScale\"")]
        [NativeName("Name", "GL_POST_CONVOLUTION_BLUE_SCALE")]
        PostConvolutionBlueScale = 0x801E,
        [Obsolete("Deprecated in favour of \"ConvolutionBlueScaleExt\"")]
        [NativeName("Name", "GL_POST_CONVOLUTION_BLUE_SCALE_EXT")]
        PostConvolutionBlueScaleExt = 0x801E,
        [Obsolete("Deprecated in favour of \"ConvolutionAlphaScale\"")]
        [NativeName("Name", "GL_POST_CONVOLUTION_ALPHA_SCALE")]
        PostConvolutionAlphaScale = 0x801F,
        [Obsolete("Deprecated in favour of \"ConvolutionAlphaScaleExt\"")]
        [NativeName("Name", "GL_POST_CONVOLUTION_ALPHA_SCALE_EXT")]
        PostConvolutionAlphaScaleExt = 0x801F,
        [Obsolete("Deprecated in favour of \"ConvolutionRedBias\"")]
        [NativeName("Name", "GL_POST_CONVOLUTION_RED_BIAS")]
        PostConvolutionRedBias = 0x8020,
        [Obsolete("Deprecated in favour of \"ConvolutionRedBiasExt\"")]
        [NativeName("Name", "GL_POST_CONVOLUTION_RED_BIAS_EXT")]
        PostConvolutionRedBiasExt = 0x8020,
        [Obsolete("Deprecated in favour of \"ConvolutionGreenBias\"")]
        [NativeName("Name", "GL_POST_CONVOLUTION_GREEN_BIAS")]
        PostConvolutionGreenBias = 0x8021,
        [Obsolete("Deprecated in favour of \"ConvolutionGreenBiasExt\"")]
        [NativeName("Name", "GL_POST_CONVOLUTION_GREEN_BIAS_EXT")]
        PostConvolutionGreenBiasExt = 0x8021,
        [Obsolete("Deprecated in favour of \"ConvolutionBlueBias\"")]
        [NativeName("Name", "GL_POST_CONVOLUTION_BLUE_BIAS")]
        PostConvolutionBlueBias = 0x8022,
        [Obsolete("Deprecated in favour of \"ConvolutionBlueBiasExt\"")]
        [NativeName("Name", "GL_POST_CONVOLUTION_BLUE_BIAS_EXT")]
        PostConvolutionBlueBiasExt = 0x8022,
        [Obsolete("Deprecated in favour of \"ConvolutionAlphaBias\"")]
        [NativeName("Name", "GL_POST_CONVOLUTION_ALPHA_BIAS")]
        PostConvolutionAlphaBias = 0x8023,
        [Obsolete("Deprecated in favour of \"ConvolutionAlphaBiasExt\"")]
        [NativeName("Name", "GL_POST_CONVOLUTION_ALPHA_BIAS_EXT")]
        PostConvolutionAlphaBiasExt = 0x8023,
        [Obsolete("Deprecated in favour of \"ColorMatrixRedScale\"")]
        [NativeName("Name", "GL_POST_COLOR_MATRIX_RED_SCALE")]
        PostColorMatrixRedScale = 0x80B4,
        [Obsolete("Deprecated in favour of \"ColorMatrixRedScaleSgi\"")]
        [NativeName("Name", "GL_POST_COLOR_MATRIX_RED_SCALE_SGI")]
        PostColorMatrixRedScaleSgi = 0x80B4,
        [Obsolete("Deprecated in favour of \"ColorMatrixGreenScale\"")]
        [NativeName("Name", "GL_POST_COLOR_MATRIX_GREEN_SCALE")]
        PostColorMatrixGreenScale = 0x80B5,
        [Obsolete("Deprecated in favour of \"ColorMatrixGreenScaleSgi\"")]
        [NativeName("Name", "GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI")]
        PostColorMatrixGreenScaleSgi = 0x80B5,
        [Obsolete("Deprecated in favour of \"ColorMatrixBlueScale\"")]
        [NativeName("Name", "GL_POST_COLOR_MATRIX_BLUE_SCALE")]
        PostColorMatrixBlueScale = 0x80B6,
        [Obsolete("Deprecated in favour of \"ColorMatrixBlueScaleSgi\"")]
        [NativeName("Name", "GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI")]
        PostColorMatrixBlueScaleSgi = 0x80B6,
        [Obsolete("Deprecated in favour of \"ColorMatrixAlphaScale\"")]
        [NativeName("Name", "GL_POST_COLOR_MATRIX_ALPHA_SCALE")]
        PostColorMatrixAlphaScale = 0x80B7,
        [Obsolete("Deprecated in favour of \"ColorMatrixAlphaScaleSgi\"")]
        [NativeName("Name", "GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI")]
        PostColorMatrixAlphaScaleSgi = 0x80B7,
        [Obsolete("Deprecated in favour of \"ColorMatrixRedBias\"")]
        [NativeName("Name", "GL_POST_COLOR_MATRIX_RED_BIAS")]
        PostColorMatrixRedBias = 0x80B8,
        [Obsolete("Deprecated in favour of \"ColorMatrixRedBiasSgi\"")]
        [NativeName("Name", "GL_POST_COLOR_MATRIX_RED_BIAS_SGI")]
        PostColorMatrixRedBiasSgi = 0x80B8,
        [Obsolete("Deprecated in favour of \"ColorMatrixGreenBias\"")]
        [NativeName("Name", "GL_POST_COLOR_MATRIX_GREEN_BIAS")]
        PostColorMatrixGreenBias = 0x80B9,
        [Obsolete("Deprecated in favour of \"ColorMatrixGreenBiasSgi\"")]
        [NativeName("Name", "GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI")]
        PostColorMatrixGreenBiasSgi = 0x80B9,
        [Obsolete("Deprecated in favour of \"ColorMatrixBlueBias\"")]
        [NativeName("Name", "GL_POST_COLOR_MATRIX_BLUE_BIAS")]
        PostColorMatrixBlueBias = 0x80BA,
        [Obsolete("Deprecated in favour of \"ColorMatrixBlueBiasSgi\"")]
        [NativeName("Name", "GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI")]
        PostColorMatrixBlueBiasSgi = 0x80BA,
        [Obsolete("Deprecated in favour of \"ColorMatrixAlphaBias\"")]
        [NativeName("Name", "GL_POST_COLOR_MATRIX_ALPHA_BIAS")]
        PostColorMatrixAlphaBias = 0x80BB,
        [Obsolete("Deprecated in favour of \"ColorMatrixAlphaBiasSgi\"")]
        [NativeName("Name", "GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI")]
        PostColorMatrixAlphaBiasSgi = 0x80BB,
        [NativeName("Name", "GL_POST_CONVOLUTION_RED_SCALE")]
        ConvolutionRedScale = 0x801C,
        [NativeName("Name", "GL_POST_CONVOLUTION_RED_SCALE_EXT")]
        ConvolutionRedScaleExt = 0x801C,
        [NativeName("Name", "GL_POST_CONVOLUTION_GREEN_SCALE")]
        ConvolutionGreenScale = 0x801D,
        [NativeName("Name", "GL_POST_CONVOLUTION_GREEN_SCALE_EXT")]
        ConvolutionGreenScaleExt = 0x801D,
        [NativeName("Name", "GL_POST_CONVOLUTION_BLUE_SCALE")]
        ConvolutionBlueScale = 0x801E,
        [NativeName("Name", "GL_POST_CONVOLUTION_BLUE_SCALE_EXT")]
        ConvolutionBlueScaleExt = 0x801E,
        [NativeName("Name", "GL_POST_CONVOLUTION_ALPHA_SCALE")]
        ConvolutionAlphaScale = 0x801F,
        [NativeName("Name", "GL_POST_CONVOLUTION_ALPHA_SCALE_EXT")]
        ConvolutionAlphaScaleExt = 0x801F,
        [NativeName("Name", "GL_POST_CONVOLUTION_RED_BIAS")]
        ConvolutionRedBias = 0x8020,
        [NativeName("Name", "GL_POST_CONVOLUTION_RED_BIAS_EXT")]
        ConvolutionRedBiasExt = 0x8020,
        [NativeName("Name", "GL_POST_CONVOLUTION_GREEN_BIAS")]
        ConvolutionGreenBias = 0x8021,
        [NativeName("Name", "GL_POST_CONVOLUTION_GREEN_BIAS_EXT")]
        ConvolutionGreenBiasExt = 0x8021,
        [NativeName("Name", "GL_POST_CONVOLUTION_BLUE_BIAS")]
        ConvolutionBlueBias = 0x8022,
        [NativeName("Name", "GL_POST_CONVOLUTION_BLUE_BIAS_EXT")]
        ConvolutionBlueBiasExt = 0x8022,
        [NativeName("Name", "GL_POST_CONVOLUTION_ALPHA_BIAS")]
        ConvolutionAlphaBias = 0x8023,
        [NativeName("Name", "GL_POST_CONVOLUTION_ALPHA_BIAS_EXT")]
        ConvolutionAlphaBiasExt = 0x8023,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_RED_SCALE")]
        ColorMatrixRedScale = 0x80B4,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_RED_SCALE_SGI")]
        ColorMatrixRedScaleSgi = 0x80B4,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_GREEN_SCALE")]
        ColorMatrixGreenScale = 0x80B5,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI")]
        ColorMatrixGreenScaleSgi = 0x80B5,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_BLUE_SCALE")]
        ColorMatrixBlueScale = 0x80B6,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI")]
        ColorMatrixBlueScaleSgi = 0x80B6,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_ALPHA_SCALE")]
        ColorMatrixAlphaScale = 0x80B7,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI")]
        ColorMatrixAlphaScaleSgi = 0x80B7,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_RED_BIAS")]
        ColorMatrixRedBias = 0x80B8,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_RED_BIAS_SGI")]
        ColorMatrixRedBiasSgi = 0x80B8,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_GREEN_BIAS")]
        ColorMatrixGreenBias = 0x80B9,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI")]
        ColorMatrixGreenBiasSgi = 0x80B9,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_BLUE_BIAS")]
        ColorMatrixBlueBias = 0x80BA,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI")]
        ColorMatrixBlueBiasSgi = 0x80BA,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_ALPHA_BIAS")]
        ColorMatrixAlphaBias = 0x80BB,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI")]
        ColorMatrixAlphaBiasSgi = 0x80BB,
    }
}
