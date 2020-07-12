// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ColorTableTargetSGI")]
    public enum ColorTableTargetSGI
    {
        [NativeName("Name", "GL_TEXTURE_COLOR_TABLE_SGI")]
        TextureColorTableSgi = 0x80BC,
        [NativeName("Name", "GL_PROXY_TEXTURE_COLOR_TABLE_SGI")]
        ProxyTextureColorTableSgi = 0x80BD,
        [NativeName("Name", "GL_COLOR_TABLE")]
        ColorTable = 0x80D0,
        [NativeName("Name", "GL_COLOR_TABLE_SGI")]
        ColorTableSgi = 0x80D0,
        [NativeName("Name", "GL_POST_CONVOLUTION_COLOR_TABLE")]
        PostConvolutionColorTable = 0x80D1,
        [NativeName("Name", "GL_POST_CONVOLUTION_COLOR_TABLE_SGI")]
        PostConvolutionColorTableSgi = 0x80D1,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_COLOR_TABLE")]
        PostColorMatrixColorTable = 0x80D2,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI")]
        PostColorMatrixColorTableSgi = 0x80D2,
        [NativeName("Name", "GL_PROXY_COLOR_TABLE")]
        ProxyColorTable = 0x80D3,
        [NativeName("Name", "GL_PROXY_COLOR_TABLE_SGI")]
        ProxyColorTableSgi = 0x80D3,
        [NativeName("Name", "GL_PROXY_POST_CONVOLUTION_COLOR_TABLE")]
        ProxyPostConvolutionColorTable = 0x80D4,
        [NativeName("Name", "GL_PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI")]
        ProxyPostConvolutionColorTableSgi = 0x80D4,
        [NativeName("Name", "GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE")]
        ProxyPostColorMatrixColorTable = 0x80D5,
        [NativeName("Name", "GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI")]
        ProxyPostColorMatrixColorTableSgi = 0x80D5,
    }
}
