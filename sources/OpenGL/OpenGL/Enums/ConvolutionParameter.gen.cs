// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ConvolutionParameter : uint
{
    ConvolutionBorderMode = unchecked((uint)0x8013),
    ConvolutionFilterScale = unchecked((uint)0x8014),
    ConvolutionFilterBias = unchecked((uint)0x8015),
    ConvolutionFormat = unchecked((uint)0x8017),
    ConvolutionWidth = unchecked((uint)0x8018),
    ConvolutionHeight = unchecked((uint)0x8019),
    MaxConvolutionWidth = unchecked((uint)0x801A),
    MaxConvolutionHeight = unchecked((uint)0x801B),
    ConvolutionBorderColor = unchecked((uint)0x8154),
    ConvolutionBorderModeEXT = unchecked((uint)0x8013),
    ConvolutionFilterScaleEXT = unchecked((uint)0x8014),
    ConvolutionFilterBiasEXT = unchecked((uint)0x8015),
    ConvolutionFormatEXT = unchecked((uint)0x8017),
    ConvolutionWidthEXT = unchecked((uint)0x8018),
    ConvolutionHeightEXT = unchecked((uint)0x8019),
    MaxConvolutionWidthEXT = unchecked((uint)0x801A),
    MaxConvolutionHeightEXT = unchecked((uint)0x801B),
}
