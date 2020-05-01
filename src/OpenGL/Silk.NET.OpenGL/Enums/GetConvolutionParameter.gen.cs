// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    public enum GetConvolutionParameter
    {
        ConvolutionBorderMode = 0x8013,
        ConvolutionBorderModeExt = 0x8013,
        ConvolutionFilterScale = 0x8014,
        ConvolutionFilterScaleExt = 0x8014,
        ConvolutionFilterBias = 0x8015,
        ConvolutionFilterBiasExt = 0x8015,
        ConvolutionFormat = 0x8017,
        ConvolutionFormatExt = 0x8017,
        ConvolutionWidth = 0x8018,
        ConvolutionWidthExt = 0x8018,
        ConvolutionHeight = 0x8019,
        ConvolutionHeightExt = 0x8019,
        MaxConvolutionWidth = 0x801A,
        MaxConvolutionWidthExt = 0x801A,
        MaxConvolutionHeight = 0x801B,
        MaxConvolutionHeightExt = 0x801B,
        ConvolutionBorderColor = 0x8154,
    }
}
