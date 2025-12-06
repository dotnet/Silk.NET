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
    [NativeName("GL_RENDERBUFFER_SAMPLES")]
    Samples = 36011,

    [NativeName("GL_RENDERBUFFER_WIDTH")]
    Width = 36162,

    [NativeName("GL_RENDERBUFFER_HEIGHT")]
    Height = 36163,

    [NativeName("GL_RENDERBUFFER_INTERNAL_FORMAT")]
    InternalFormat = 36164,

    [NativeName("GL_RENDERBUFFER_RED_SIZE")]
    RedSize = 36176,

    [NativeName("GL_RENDERBUFFER_GREEN_SIZE")]
    GreenSize = 36177,

    [NativeName("GL_RENDERBUFFER_BLUE_SIZE")]
    BlueSize = 36178,

    [NativeName("GL_RENDERBUFFER_ALPHA_SIZE")]
    AlphaSize = 36179,

    [NativeName("GL_RENDERBUFFER_DEPTH_SIZE")]
    DepthSize = 36180,

    [NativeName("GL_RENDERBUFFER_STENCIL_SIZE")]
    StencilSize = 36181,

    [NativeName("GL_RENDERBUFFER_STORAGE_SAMPLES_AMD")]
    StorageSamplesAMD = 37298,

    [NativeName("GL_RENDERBUFFER_SAMPLES_EXT")]
    SamplesEXT = 36011,

    [NativeName("GL_RENDERBUFFER_WIDTH_EXT")]
    WidthEXT = 36162,

    [NativeName("GL_RENDERBUFFER_HEIGHT_EXT")]
    HeightEXT = 36163,

    [NativeName("GL_RENDERBUFFER_INTERNAL_FORMAT_EXT")]
    InternalFormatEXT = 36164,

    [NativeName("GL_RENDERBUFFER_RED_SIZE_EXT")]
    RedSizeEXT = 36176,

    [NativeName("GL_RENDERBUFFER_GREEN_SIZE_EXT")]
    GreenSizeEXT = 36177,

    [NativeName("GL_RENDERBUFFER_BLUE_SIZE_EXT")]
    BlueSizeEXT = 36178,

    [NativeName("GL_RENDERBUFFER_ALPHA_SIZE_EXT")]
    AlphaSizeEXT = 36179,

    [NativeName("GL_RENDERBUFFER_DEPTH_SIZE_EXT")]
    DepthSizeEXT = 36180,

    [NativeName("GL_RENDERBUFFER_STENCIL_SIZE_EXT")]
    StencilSizeEXT = 36181,

    [NativeName("GL_RENDERBUFFER_COVERAGE_SAMPLES_NV")]
    CoverageSamplesNV = 36011,

    [NativeName("GL_RENDERBUFFER_COLOR_SAMPLES_NV")]
    ColorSamplesNV = 36368,

    [NativeName("GL_RENDERBUFFER_SAMPLES_ANGLE")]
    SamplesANGLE = 36011,

    [NativeName("GL_RENDERBUFFER_SAMPLES_APPLE")]
    SamplesAPPLE = 36011,

    [NativeName("GL_RENDERBUFFER_SAMPLES_IMG")]
    SamplesIMG = 37171,

    [NativeName("GL_RENDERBUFFER_SAMPLES_NV")]
    SamplesNV = 36011,

    [NativeName("GL_RENDERBUFFER_WIDTH_OES")]
    WidthOES = 36162,

    [NativeName("GL_RENDERBUFFER_HEIGHT_OES")]
    HeightOES = 36163,

    [NativeName("GL_RENDERBUFFER_INTERNAL_FORMAT_OES")]
    InternalFormatOES = 36164,

    [NativeName("GL_RENDERBUFFER_RED_SIZE_OES")]
    RedSizeOES = 36176,

    [NativeName("GL_RENDERBUFFER_GREEN_SIZE_OES")]
    GreenSizeOES = 36177,

    [NativeName("GL_RENDERBUFFER_BLUE_SIZE_OES")]
    BlueSizeOES = 36178,

    [NativeName("GL_RENDERBUFFER_ALPHA_SIZE_OES")]
    AlphaSizeOES = 36179,

    [NativeName("GL_RENDERBUFFER_DEPTH_SIZE_OES")]
    DepthSizeOES = 36180,

    [NativeName("GL_RENDERBUFFER_STENCIL_SIZE_OES")]
    StencilSizeOES = 36181,
}
