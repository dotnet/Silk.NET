// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "PixelTransferParameter")]
    public enum PixelTransferParameter : int
    {
        [NativeName("Name", "GL_POST_CONVOLUTION_RED_SCALE")]
        PostConvolutionRedScale = 0x801C,
        [NativeName("Name", "GL_POST_CONVOLUTION_RED_SCALE_EXT")]
        PostConvolutionRedScaleExt = 0x801C,
        [NativeName("Name", "GL_POST_CONVOLUTION_GREEN_SCALE")]
        PostConvolutionGreenScale = 0x801D,
        [NativeName("Name", "GL_POST_CONVOLUTION_GREEN_SCALE_EXT")]
        PostConvolutionGreenScaleExt = 0x801D,
        [NativeName("Name", "GL_POST_CONVOLUTION_BLUE_SCALE")]
        PostConvolutionBlueScale = 0x801E,
        [NativeName("Name", "GL_POST_CONVOLUTION_BLUE_SCALE_EXT")]
        PostConvolutionBlueScaleExt = 0x801E,
        [NativeName("Name", "GL_POST_CONVOLUTION_ALPHA_SCALE")]
        PostConvolutionAlphaScale = 0x801F,
        [NativeName("Name", "GL_POST_CONVOLUTION_ALPHA_SCALE_EXT")]
        PostConvolutionAlphaScaleExt = 0x801F,
        [NativeName("Name", "GL_POST_CONVOLUTION_RED_BIAS")]
        PostConvolutionRedBias = 0x8020,
        [NativeName("Name", "GL_POST_CONVOLUTION_RED_BIAS_EXT")]
        PostConvolutionRedBiasExt = 0x8020,
        [NativeName("Name", "GL_POST_CONVOLUTION_GREEN_BIAS")]
        PostConvolutionGreenBias = 0x8021,
        [NativeName("Name", "GL_POST_CONVOLUTION_GREEN_BIAS_EXT")]
        PostConvolutionGreenBiasExt = 0x8021,
        [NativeName("Name", "GL_POST_CONVOLUTION_BLUE_BIAS")]
        PostConvolutionBlueBias = 0x8022,
        [NativeName("Name", "GL_POST_CONVOLUTION_BLUE_BIAS_EXT")]
        PostConvolutionBlueBiasExt = 0x8022,
        [NativeName("Name", "GL_POST_CONVOLUTION_ALPHA_BIAS")]
        PostConvolutionAlphaBias = 0x8023,
        [NativeName("Name", "GL_POST_CONVOLUTION_ALPHA_BIAS_EXT")]
        PostConvolutionAlphaBiasExt = 0x8023,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_RED_SCALE")]
        PostColorMatrixRedScale = 0x80B4,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_RED_SCALE_SGI")]
        PostColorMatrixRedScaleSgi = 0x80B4,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_GREEN_SCALE")]
        PostColorMatrixGreenScale = 0x80B5,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI")]
        PostColorMatrixGreenScaleSgi = 0x80B5,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_BLUE_SCALE")]
        PostColorMatrixBlueScale = 0x80B6,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI")]
        PostColorMatrixBlueScaleSgi = 0x80B6,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_ALPHA_SCALE")]
        PostColorMatrixAlphaScale = 0x80B7,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI")]
        PostColorMatrixAlphaScaleSgi = 0x80B7,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_RED_BIAS")]
        PostColorMatrixRedBias = 0x80B8,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_RED_BIAS_SGI")]
        PostColorMatrixRedBiasSgi = 0x80B8,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_GREEN_BIAS")]
        PostColorMatrixGreenBias = 0x80B9,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI")]
        PostColorMatrixGreenBiasSgi = 0x80B9,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_BLUE_BIAS")]
        PostColorMatrixBlueBias = 0x80BA,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI")]
        PostColorMatrixBlueBiasSgi = 0x80BA,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_ALPHA_BIAS")]
        PostColorMatrixAlphaBias = 0x80BB,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI")]
        PostColorMatrixAlphaBiasSgi = 0x80BB,
    }
}
