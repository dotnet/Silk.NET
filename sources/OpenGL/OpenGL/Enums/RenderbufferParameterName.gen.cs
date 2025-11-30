// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("RenderbufferParameterName")]
[Transformed]
public enum RenderbufferParameterName : uint
{
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

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("GL_RENDERBUFFER_STORAGE_SAMPLES_AMD")]
    StorageSamplesamd = unchecked((uint)0x91B2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RENDERBUFFER_SAMPLES_EXT")]
    Samplesext = unchecked((uint)0x8CAB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RENDERBUFFER_WIDTH_EXT")]
    Widthext = unchecked((uint)0x8D42),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RENDERBUFFER_HEIGHT_EXT")]
    Heightext = unchecked((uint)0x8D43),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RENDERBUFFER_INTERNAL_FORMAT_EXT")]
    InternalFormatext = unchecked((uint)0x8D44),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RENDERBUFFER_RED_SIZE_EXT")]
    RedSizeext = unchecked((uint)0x8D50),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RENDERBUFFER_GREEN_SIZE_EXT")]
    GreenSizeext = unchecked((uint)0x8D51),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RENDERBUFFER_BLUE_SIZE_EXT")]
    BlueSizeext = unchecked((uint)0x8D52),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RENDERBUFFER_ALPHA_SIZE_EXT")]
    AlphaSizeext = unchecked((uint)0x8D53),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RENDERBUFFER_DEPTH_SIZE_EXT")]
    DepthSizeext = unchecked((uint)0x8D54),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RENDERBUFFER_STENCIL_SIZE_EXT")]
    StencilSizeext = unchecked((uint)0x8D55),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RENDERBUFFER_COVERAGE_SAMPLES_NV")]
    CoverageSamplesnv = unchecked((uint)0x8CAB),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RENDERBUFFER_COLOR_SAMPLES_NV")]
    ColorSamplesnv = unchecked((uint)0x8E10),

    [NameAffix("Suffix", "ANGLE", 0)]
    [NativeName("GL_RENDERBUFFER_SAMPLES_ANGLE")]
    Samplesangle = unchecked((uint)0x8CAB),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_RENDERBUFFER_SAMPLES_APPLE")]
    Samplesapple = unchecked((uint)0x8CAB),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_RENDERBUFFER_SAMPLES_IMG")]
    Samplesimg = unchecked((uint)0x9133),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RENDERBUFFER_SAMPLES_NV")]
    Samplesnv = unchecked((uint)0x8CAB),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RENDERBUFFER_WIDTH_OES")]
    Widthoes = unchecked((uint)0x8D42),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RENDERBUFFER_HEIGHT_OES")]
    Heightoes = unchecked((uint)0x8D43),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RENDERBUFFER_INTERNAL_FORMAT_OES")]
    InternalFormatoes = unchecked((uint)0x8D44),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RENDERBUFFER_RED_SIZE_OES")]
    RedSizeoes = unchecked((uint)0x8D50),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RENDERBUFFER_GREEN_SIZE_OES")]
    GreenSizeoes = unchecked((uint)0x8D51),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RENDERBUFFER_BLUE_SIZE_OES")]
    BlueSizeoes = unchecked((uint)0x8D52),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RENDERBUFFER_ALPHA_SIZE_OES")]
    AlphaSizeoes = unchecked((uint)0x8D53),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RENDERBUFFER_DEPTH_SIZE_OES")]
    DepthSizeoes = unchecked((uint)0x8D54),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_RENDERBUFFER_STENCIL_SIZE_OES")]
    StencilSizeoes = unchecked((uint)0x8D55),
}
