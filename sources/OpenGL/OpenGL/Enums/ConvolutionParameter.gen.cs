// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ConvolutionParameter")]
[Transformed]
public enum ConvolutionParameter : uint
{
    [NativeName("GL_CONVOLUTION_BORDER_MODE")]
    ConvolutionBorderMode = unchecked((uint)0x8013),

    [NativeName("GL_CONVOLUTION_FILTER_SCALE")]
    ConvolutionFilterScale = unchecked((uint)0x8014),

    [NativeName("GL_CONVOLUTION_FILTER_BIAS")]
    ConvolutionFilterBias = unchecked((uint)0x8015),

    [NativeName("GL_CONVOLUTION_FORMAT")]
    ConvolutionFormat = unchecked((uint)0x8017),

    [NativeName("GL_CONVOLUTION_WIDTH")]
    ConvolutionWidth = unchecked((uint)0x8018),

    [NativeName("GL_CONVOLUTION_HEIGHT")]
    ConvolutionHeight = unchecked((uint)0x8019),

    [NativeName("GL_MAX_CONVOLUTION_WIDTH")]
    MaxConvolutionWidth = unchecked((uint)0x801A),

    [NativeName("GL_MAX_CONVOLUTION_HEIGHT")]
    MaxConvolutionHeight = unchecked((uint)0x801B),

    [NativeName("GL_CONVOLUTION_BORDER_COLOR")]
    ConvolutionBorderColor = unchecked((uint)0x8154),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONVOLUTION_BORDER_MODE_EXT")]
    ConvolutionBorderModeext = unchecked((uint)0x8013),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONVOLUTION_FILTER_SCALE_EXT")]
    ConvolutionFilterScaleext = unchecked((uint)0x8014),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONVOLUTION_FILTER_BIAS_EXT")]
    ConvolutionFilterBiasext = unchecked((uint)0x8015),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONVOLUTION_FORMAT_EXT")]
    ConvolutionFormatext = unchecked((uint)0x8017),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONVOLUTION_WIDTH_EXT")]
    ConvolutionWidthext = unchecked((uint)0x8018),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONVOLUTION_HEIGHT_EXT")]
    ConvolutionHeightext = unchecked((uint)0x8019),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_CONVOLUTION_WIDTH_EXT")]
    MaxConvolutionWidthext = unchecked((uint)0x801A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MAX_CONVOLUTION_HEIGHT_EXT")]
    MaxConvolutionHeightext = unchecked((uint)0x801B),
}
