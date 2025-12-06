// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ConvolutionParameter")]
public enum ConvolutionParameter : uint
{
    [NativeName("GL_CONVOLUTION_BORDER_MODE")]
    ConvolutionBorderMode = 32787,

    [NativeName("GL_CONVOLUTION_FILTER_SCALE")]
    ConvolutionFilterScale = 32788,

    [NativeName("GL_CONVOLUTION_FILTER_BIAS")]
    ConvolutionFilterBias = 32789,

    [NativeName("GL_CONVOLUTION_FORMAT")]
    ConvolutionFormat = 32791,

    [NativeName("GL_CONVOLUTION_WIDTH")]
    ConvolutionWidth = 32792,

    [NativeName("GL_CONVOLUTION_HEIGHT")]
    ConvolutionHeight = 32793,

    [NativeName("GL_MAX_CONVOLUTION_WIDTH")]
    MaxConvolutionWidth = 32794,

    [NativeName("GL_MAX_CONVOLUTION_HEIGHT")]
    MaxConvolutionHeight = 32795,

    [NativeName("GL_CONVOLUTION_BORDER_COLOR")]
    ConvolutionBorderColor = 33108,

    [NativeName("GL_CONVOLUTION_BORDER_MODE_EXT")]
    ConvolutionBorderModeEXT = 32787,

    [NativeName("GL_CONVOLUTION_FILTER_SCALE_EXT")]
    ConvolutionFilterScaleEXT = 32788,

    [NativeName("GL_CONVOLUTION_FILTER_BIAS_EXT")]
    ConvolutionFilterBiasEXT = 32789,

    [NativeName("GL_CONVOLUTION_FORMAT_EXT")]
    ConvolutionFormatEXT = 32791,

    [NativeName("GL_CONVOLUTION_WIDTH_EXT")]
    ConvolutionWidthEXT = 32792,

    [NativeName("GL_CONVOLUTION_HEIGHT_EXT")]
    ConvolutionHeightEXT = 32793,

    [NativeName("GL_MAX_CONVOLUTION_WIDTH_EXT")]
    MaxConvolutionWidthEXT = 32794,

    [NativeName("GL_MAX_CONVOLUTION_HEIGHT_EXT")]
    MaxConvolutionHeightEXT = 32795,
}
