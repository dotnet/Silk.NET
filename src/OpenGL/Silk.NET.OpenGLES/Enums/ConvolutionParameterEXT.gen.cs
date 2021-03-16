// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ConvolutionParameterEXT")]
    public enum ConvolutionParameterEXT : int
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
    }
}
