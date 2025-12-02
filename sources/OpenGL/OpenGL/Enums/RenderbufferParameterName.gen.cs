// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("RenderbufferParameterName")]
public enum RenderbufferParameterName : uint
{
    [NativeName("GL_RENDERBUFFER_WIDTH_OES")]
    WidthOES = unchecked((uint)0x8D42),

    [NativeName("GL_RENDERBUFFER_HEIGHT_OES")]
    HeightOES = unchecked((uint)0x8D43),

    [NativeName("GL_RENDERBUFFER_INTERNAL_FORMAT_OES")]
    InternalFormatOES = unchecked((uint)0x8D44),

    [NativeName("GL_RENDERBUFFER_RED_SIZE_OES")]
    RedSizeOES = unchecked((uint)0x8D50),

    [NativeName("GL_RENDERBUFFER_GREEN_SIZE_OES")]
    GreenSizeOES = unchecked((uint)0x8D51),

    [NativeName("GL_RENDERBUFFER_BLUE_SIZE_OES")]
    BlueSizeOES = unchecked((uint)0x8D52),

    [NativeName("GL_RENDERBUFFER_ALPHA_SIZE_OES")]
    AlphaSizeOES = unchecked((uint)0x8D53),

    [NativeName("GL_RENDERBUFFER_DEPTH_SIZE_OES")]
    DepthSizeOES = unchecked((uint)0x8D54),

    [NativeName("GL_RENDERBUFFER_STENCIL_SIZE_OES")]
    StencilSizeOES = unchecked((uint)0x8D55),

    [NativeName("GL_RENDERBUFFER_SAMPLES_APPLE")]
    SamplesAPPLE = unchecked((uint)0x8CAB),

    [NativeName("GL_RENDERBUFFER_SAMPLES_EXT")]
    SamplesEXT = unchecked((uint)0x8CAB),

    [NativeName("GL_RENDERBUFFER_SAMPLES_IMG")]
    SamplesIMG = unchecked((uint)0x9133),

    [NativeName("GL_RENDERBUFFER_SAMPLES")]
    Samples = unchecked((uint)0x8CAB),

    [NativeName("GL_RENDERBUFFER_WIDTH")]
    Width = unchecked((uint)0x8D42),

    [NativeName("GL_RENDERBUFFER_HEIGHT")]
    Height = unchecked((uint)0x8D43),

    [NativeName("GL_RENDERBUFFER_INTERNAL_FORMAT")]
    InternalFormat = unchecked((uint)0x8D44),

    [NativeName("GL_RENDERBUFFER_RED_SIZE")]
    RedSize = unchecked((uint)0x8D50),

    [NativeName("GL_RENDERBUFFER_GREEN_SIZE")]
    GreenSize = unchecked((uint)0x8D51),

    [NativeName("GL_RENDERBUFFER_BLUE_SIZE")]
    BlueSize = unchecked((uint)0x8D52),

    [NativeName("GL_RENDERBUFFER_ALPHA_SIZE")]
    AlphaSize = unchecked((uint)0x8D53),

    [NativeName("GL_RENDERBUFFER_DEPTH_SIZE")]
    DepthSize = unchecked((uint)0x8D54),

    [NativeName("GL_RENDERBUFFER_STENCIL_SIZE")]
    StencilSize = unchecked((uint)0x8D55),

    [NativeName("GL_RENDERBUFFER_STORAGE_SAMPLES_AMD")]
    StorageSamplesAMD = unchecked((uint)0x91B2),

    [NativeName("GL_RENDERBUFFER_WIDTH_EXT")]
    WidthEXT = unchecked((uint)0x8D42),

    [NativeName("GL_RENDERBUFFER_HEIGHT_EXT")]
    HeightEXT = unchecked((uint)0x8D43),

    [NativeName("GL_RENDERBUFFER_INTERNAL_FORMAT_EXT")]
    InternalFormatEXT = unchecked((uint)0x8D44),

    [NativeName("GL_RENDERBUFFER_RED_SIZE_EXT")]
    RedSizeEXT = unchecked((uint)0x8D50),

    [NativeName("GL_RENDERBUFFER_GREEN_SIZE_EXT")]
    GreenSizeEXT = unchecked((uint)0x8D51),

    [NativeName("GL_RENDERBUFFER_BLUE_SIZE_EXT")]
    BlueSizeEXT = unchecked((uint)0x8D52),

    [NativeName("GL_RENDERBUFFER_ALPHA_SIZE_EXT")]
    AlphaSizeEXT = unchecked((uint)0x8D53),

    [NativeName("GL_RENDERBUFFER_DEPTH_SIZE_EXT")]
    DepthSizeEXT = unchecked((uint)0x8D54),

    [NativeName("GL_RENDERBUFFER_STENCIL_SIZE_EXT")]
    StencilSizeEXT = unchecked((uint)0x8D55),

    [NativeName("GL_RENDERBUFFER_COVERAGE_SAMPLES_NV")]
    CoverageSamplesNV = unchecked((uint)0x8CAB),

    [NativeName("GL_RENDERBUFFER_COLOR_SAMPLES_NV")]
    ColorSamplesNV = unchecked((uint)0x8E10),

    [NativeName("GL_RENDERBUFFER_SAMPLES_ANGLE")]
    SamplesANGLE = unchecked((uint)0x8CAB),

    [NativeName("GL_RENDERBUFFER_SAMPLES_NV")]
    SamplesNV = unchecked((uint)0x8CAB),
}
