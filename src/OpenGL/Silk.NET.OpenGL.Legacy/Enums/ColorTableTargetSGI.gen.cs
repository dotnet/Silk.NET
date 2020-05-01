// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    public enum ColorTableTargetSGI
    {
        TextureColorTableSgi = 0x80BC,
        ProxyTextureColorTableSgi = 0x80BD,
        ColorTable = 0x80D0,
        ColorTableSgi = 0x80D0,
        PostConvolutionColorTable = 0x80D1,
        PostConvolutionColorTableSgi = 0x80D1,
        PostColorMatrixColorTable = 0x80D2,
        PostColorMatrixColorTableSgi = 0x80D2,
        ProxyColorTable = 0x80D3,
        ProxyColorTableSgi = 0x80D3,
        ProxyPostConvolutionColorTable = 0x80D4,
        ProxyPostConvolutionColorTableSgi = 0x80D4,
        ProxyPostColorMatrixColorTable = 0x80D5,
        ProxyPostColorMatrixColorTableSgi = 0x80D5,
    }
}
