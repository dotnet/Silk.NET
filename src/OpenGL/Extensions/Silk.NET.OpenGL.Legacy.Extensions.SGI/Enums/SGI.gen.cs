// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGI
{
    [NativeName("Name", "GLenum")]
    public enum SGI : int
    {
        [NativeName("Name", "GL_COLOR_MATRIX_SGI")]
        ColorMatrixSgi = 0x80B1,
        [NativeName("Name", "GL_COLOR_MATRIX_STACK_DEPTH_SGI")]
        ColorMatrixStackDepthSgi = 0x80B2,
        [NativeName("Name", "GL_MAX_COLOR_MATRIX_STACK_DEPTH_SGI")]
        MaxColorMatrixStackDepthSgi = 0x80B3,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_RED_SCALE_SGI")]
        PostColorMatrixRedScaleSgi = 0x80B4,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI")]
        PostColorMatrixGreenScaleSgi = 0x80B5,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI")]
        PostColorMatrixBlueScaleSgi = 0x80B6,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI")]
        PostColorMatrixAlphaScaleSgi = 0x80B7,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_RED_BIAS_SGI")]
        PostColorMatrixRedBiasSgi = 0x80B8,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI")]
        PostColorMatrixGreenBiasSgi = 0x80B9,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI")]
        PostColorMatrixBlueBiasSgi = 0x80BA,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI")]
        PostColorMatrixAlphaBiasSgi = 0x80BB,
        [NativeName("Name", "GL_COLOR_TABLE_SGI")]
        ColorTableSgi = 0x80D0,
        [NativeName("Name", "GL_POST_CONVOLUTION_COLOR_TABLE_SGI")]
        PostConvolutionColorTableSgi = 0x80D1,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI")]
        PostColorMatrixColorTableSgi = 0x80D2,
        [NativeName("Name", "GL_PROXY_COLOR_TABLE_SGI")]
        ProxyColorTableSgi = 0x80D3,
        [NativeName("Name", "GL_PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI")]
        ProxyPostConvolutionColorTableSgi = 0x80D4,
        [NativeName("Name", "GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI")]
        ProxyPostColorMatrixColorTableSgi = 0x80D5,
        [NativeName("Name", "GL_COLOR_TABLE_SCALE_SGI")]
        ColorTableScaleSgi = 0x80D6,
        [NativeName("Name", "GL_COLOR_TABLE_BIAS_SGI")]
        ColorTableBiasSgi = 0x80D7,
        [NativeName("Name", "GL_COLOR_TABLE_FORMAT_SGI")]
        ColorTableFormatSgi = 0x80D8,
        [NativeName("Name", "GL_COLOR_TABLE_WIDTH_SGI")]
        ColorTableWidthSgi = 0x80D9,
        [NativeName("Name", "GL_COLOR_TABLE_RED_SIZE_SGI")]
        ColorTableRedSizeSgi = 0x80DA,
        [NativeName("Name", "GL_COLOR_TABLE_GREEN_SIZE_SGI")]
        ColorTableGreenSizeSgi = 0x80DB,
        [NativeName("Name", "GL_COLOR_TABLE_BLUE_SIZE_SGI")]
        ColorTableBlueSizeSgi = 0x80DC,
        [NativeName("Name", "GL_COLOR_TABLE_ALPHA_SIZE_SGI")]
        ColorTableAlphaSizeSgi = 0x80DD,
        [NativeName("Name", "GL_COLOR_TABLE_LUMINANCE_SIZE_SGI")]
        ColorTableLuminanceSizeSgi = 0x80DE,
        [NativeName("Name", "GL_COLOR_TABLE_INTENSITY_SIZE_SGI")]
        ColorTableIntensitySizeSgi = 0x80DF,
        [NativeName("Name", "GL_TEXTURE_COLOR_TABLE_SGI")]
        TextureColorTableSgi = 0x80BC,
        [NativeName("Name", "GL_PROXY_TEXTURE_COLOR_TABLE_SGI")]
        ProxyTextureColorTableSgi = 0x80BD,
    }
}
