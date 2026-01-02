// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PixelTransferParameter : uint
{
    MapColor = unchecked((uint)0x0D10),
    MapStencil = unchecked((uint)0x0D11),
    IndexShift = unchecked((uint)0x0D12),
    IndexOffset = unchecked((uint)0x0D13),
    RedScale = unchecked((uint)0x0D14),
    RedBias = unchecked((uint)0x0D15),
    GreenScale = unchecked((uint)0x0D18),
    GreenBias = unchecked((uint)0x0D19),
    BlueScale = unchecked((uint)0x0D1A),
    BlueBias = unchecked((uint)0x0D1B),
    AlphaScale = unchecked((uint)0x0D1C),
    AlphaBias = unchecked((uint)0x0D1D),
    DepthScale = unchecked((uint)0x0D1E),
    DepthBias = unchecked((uint)0x0D1F),
    PostConvolutionRedScale = unchecked((uint)0x801C),
    PostConvolutionGreenScale = unchecked((uint)0x801D),
    PostConvolutionBlueScale = unchecked((uint)0x801E),
    PostConvolutionAlphaScale = unchecked((uint)0x801F),
    PostConvolutionRedBias = unchecked((uint)0x8020),
    PostConvolutionGreenBias = unchecked((uint)0x8021),
    PostConvolutionBlueBias = unchecked((uint)0x8022),
    PostConvolutionAlphaBias = unchecked((uint)0x8023),
    PostColorMatrixRedScale = unchecked((uint)0x80B4),
    PostColorMatrixGreenScale = unchecked((uint)0x80B5),
    PostColorMatrixBlueScale = unchecked((uint)0x80B6),
    PostColorMatrixAlphaScale = unchecked((uint)0x80B7),
    PostColorMatrixRedBias = unchecked((uint)0x80B8),
    PostColorMatrixGreenBias = unchecked((uint)0x80B9),
    PostColorMatrixBlueBias = unchecked((uint)0x80BA),
    PostColorMatrixAlphaBias = unchecked((uint)0x80BB),
    PostConvolutionRedScaleEXT = unchecked((uint)0x801C),
    PostConvolutionGreenScaleEXT = unchecked((uint)0x801D),
    PostConvolutionBlueScaleEXT = unchecked((uint)0x801E),
    PostConvolutionAlphaScaleEXT = unchecked((uint)0x801F),
    PostConvolutionRedBiasEXT = unchecked((uint)0x8020),
    PostConvolutionGreenBiasEXT = unchecked((uint)0x8021),
    PostConvolutionBlueBiasEXT = unchecked((uint)0x8022),
    PostConvolutionAlphaBiasEXT = unchecked((uint)0x8023),
    PostColorMatrixRedScaleSGI = unchecked((uint)0x80B4),
    PostColorMatrixGreenScaleSGI = unchecked((uint)0x80B5),
    PostColorMatrixBlueScaleSGI = unchecked((uint)0x80B6),
    PostColorMatrixAlphaScaleSGI = unchecked((uint)0x80B7),
    PostColorMatrixRedBiasSGI = unchecked((uint)0x80B8),
    PostColorMatrixGreenBiasSGI = unchecked((uint)0x80B9),
    PostColorMatrixBlueBiasSGI = unchecked((uint)0x80BA),
    PostColorMatrixAlphaBiasSGI = unchecked((uint)0x80BB),
}
