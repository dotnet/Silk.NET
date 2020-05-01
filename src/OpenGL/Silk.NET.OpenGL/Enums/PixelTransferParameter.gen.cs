// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    public enum PixelTransferParameter
    {
        PostConvolutionRedScale = 0x801C,
        PostConvolutionRedScaleExt = 0x801C,
        PostConvolutionGreenScale = 0x801D,
        PostConvolutionGreenScaleExt = 0x801D,
        PostConvolutionBlueScale = 0x801E,
        PostConvolutionBlueScaleExt = 0x801E,
        PostConvolutionAlphaScale = 0x801F,
        PostConvolutionAlphaScaleExt = 0x801F,
        PostConvolutionRedBias = 0x8020,
        PostConvolutionRedBiasExt = 0x8020,
        PostConvolutionGreenBias = 0x8021,
        PostConvolutionGreenBiasExt = 0x8021,
        PostConvolutionBlueBias = 0x8022,
        PostConvolutionBlueBiasExt = 0x8022,
        PostConvolutionAlphaBias = 0x8023,
        PostConvolutionAlphaBiasExt = 0x8023,
        PostColorMatrixRedScale = 0x80B4,
        PostColorMatrixRedScaleSgi = 0x80B4,
        PostColorMatrixGreenScale = 0x80B5,
        PostColorMatrixGreenScaleSgi = 0x80B5,
        PostColorMatrixBlueScale = 0x80B6,
        PostColorMatrixBlueScaleSgi = 0x80B6,
        PostColorMatrixAlphaScale = 0x80B7,
        PostColorMatrixAlphaScaleSgi = 0x80B7,
        PostColorMatrixRedBias = 0x80B8,
        PostColorMatrixRedBiasSgi = 0x80B8,
        PostColorMatrixGreenBias = 0x80B9,
        PostColorMatrixGreenBiasSgi = 0x80B9,
        PostColorMatrixBlueBias = 0x80BA,
        PostColorMatrixBlueBiasSgi = 0x80BA,
        PostColorMatrixAlphaBias = 0x80BB,
        PostColorMatrixAlphaBiasSgi = 0x80BB,
    }
}
