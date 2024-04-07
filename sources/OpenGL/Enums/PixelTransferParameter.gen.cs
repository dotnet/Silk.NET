// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PixelTransferParameter : uint
{
    MapColor = 0x0D10,
    MapStencil = 0x0D11,
    IndexShift = 0x0D12,
    IndexOffset = 0x0D13,
    RedScale = 0x0D14,
    RedBias = 0x0D15,
    GreenScale = 0x0D18,
    GreenBias = 0x0D19,
    BlueScale = 0x0D1A,
    BlueBias = 0x0D1B,
    AlphaScale = 0x0D1C,
    AlphaBias = 0x0D1D,
    DepthScale = 0x0D1E,
    DepthBias = 0x0D1F,
    PostConvolutionRedScale = 0x801C,
    PostConvolutionGreenScale = 0x801D,
    PostConvolutionBlueScale = 0x801E,
    PostConvolutionAlphaScale = 0x801F,
    PostConvolutionRedBias = 0x8020,
    PostConvolutionGreenBias = 0x8021,
    PostConvolutionBlueBias = 0x8022,
    PostConvolutionAlphaBias = 0x8023,
    PostColorMatrixRedScale = 0x80B4,
    PostColorMatrixGreenScale = 0x80B5,
    PostColorMatrixBlueScale = 0x80B6,
    PostColorMatrixAlphaScale = 0x80B7,
    PostColorMatrixRedBias = 0x80B8,
    PostColorMatrixGreenBias = 0x80B9,
    PostColorMatrixBlueBias = 0x80BA,
    PostColorMatrixAlphaBias = 0x80BB,
    PostConvolutionRedScaleEXT = 0x801C,
    PostConvolutionGreenScaleEXT = 0x801D,
    PostConvolutionBlueScaleEXT = 0x801E,
    PostConvolutionAlphaScaleEXT = 0x801F,
    PostConvolutionRedBiasEXT = 0x8020,
    PostConvolutionGreenBiasEXT = 0x8021,
    PostConvolutionBlueBiasEXT = 0x8022,
    PostConvolutionAlphaBiasEXT = 0x8023,
    PostColorMatrixRedScaleSGI = 0x80B4,
    PostColorMatrixGreenScaleSGI = 0x80B5,
    PostColorMatrixBlueScaleSGI = 0x80B6,
    PostColorMatrixAlphaScaleSGI = 0x80B7,
    PostColorMatrixRedBiasSGI = 0x80B8,
    PostColorMatrixGreenBiasSGI = 0x80B9,
    PostColorMatrixBlueBiasSGI = 0x80BA,
    PostColorMatrixAlphaBiasSGI = 0x80BB
}
