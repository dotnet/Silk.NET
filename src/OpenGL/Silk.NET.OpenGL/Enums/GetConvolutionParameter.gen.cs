// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "GetConvolutionParameter")]
    public enum GetConvolutionParameter : int
    {
        [NativeName("Name", "GL_CONVOLUTION_BORDER_MODE")]
        ConvolutionBorderMode = 0x8013,
        [NativeName("Name", "GL_CONVOLUTION_BORDER_MODE_EXT")]
        ConvolutionBorderModeExt = 0x8013,
        [NativeName("Name", "GL_CONVOLUTION_FILTER_SCALE")]
        ConvolutionFilterScale = 0x8014,
        [NativeName("Name", "GL_CONVOLUTION_FILTER_SCALE_EXT")]
        ConvolutionFilterScaleExt = 0x8014,
        [NativeName("Name", "GL_CONVOLUTION_FILTER_BIAS")]
        ConvolutionFilterBias = 0x8015,
        [NativeName("Name", "GL_CONVOLUTION_FILTER_BIAS_EXT")]
        ConvolutionFilterBiasExt = 0x8015,
        [NativeName("Name", "GL_CONVOLUTION_FORMAT")]
        ConvolutionFormat = 0x8017,
        [NativeName("Name", "GL_CONVOLUTION_FORMAT_EXT")]
        ConvolutionFormatExt = 0x8017,
        [NativeName("Name", "GL_CONVOLUTION_WIDTH")]
        ConvolutionWidth = 0x8018,
        [NativeName("Name", "GL_CONVOLUTION_WIDTH_EXT")]
        ConvolutionWidthExt = 0x8018,
        [NativeName("Name", "GL_CONVOLUTION_HEIGHT")]
        ConvolutionHeight = 0x8019,
        [NativeName("Name", "GL_CONVOLUTION_HEIGHT_EXT")]
        ConvolutionHeightExt = 0x8019,
        [NativeName("Name", "GL_MAX_CONVOLUTION_WIDTH")]
        MaxConvolutionWidth = 0x801A,
        [NativeName("Name", "GL_MAX_CONVOLUTION_WIDTH_EXT")]
        MaxConvolutionWidthExt = 0x801A,
        [NativeName("Name", "GL_MAX_CONVOLUTION_HEIGHT")]
        MaxConvolutionHeight = 0x801B,
        [NativeName("Name", "GL_MAX_CONVOLUTION_HEIGHT_EXT")]
        MaxConvolutionHeightExt = 0x801B,
        [NativeName("Name", "GL_CONVOLUTION_BORDER_COLOR")]
        ConvolutionBorderColor = 0x8154,
    }
}
