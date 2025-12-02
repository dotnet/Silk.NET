// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "EXT", -1)]
[NativeName("GetHistogramParameterPNameEXT")]
public enum GetHistogramParameterPName : uint
{
    [NativeName("GL_HISTOGRAM_WIDTH")]
    Width = 32806,

    [NativeName("GL_HISTOGRAM_FORMAT")]
    Format = 32807,

    [NativeName("GL_HISTOGRAM_RED_SIZE")]
    RedSize = 32808,

    [NativeName("GL_HISTOGRAM_GREEN_SIZE")]
    GreenSize = 32809,

    [NativeName("GL_HISTOGRAM_BLUE_SIZE")]
    BlueSize = 32810,

    [NativeName("GL_HISTOGRAM_ALPHA_SIZE")]
    AlphaSize = 32811,

    [NativeName("GL_HISTOGRAM_LUMINANCE_SIZE")]
    LuminanceSize = 32812,

    [NativeName("GL_HISTOGRAM_SINK")]
    Sink = 32813,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HISTOGRAM_WIDTH_EXT")]
    WidthEXT = 32806,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HISTOGRAM_FORMAT_EXT")]
    FormatEXT = 32807,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HISTOGRAM_RED_SIZE_EXT")]
    RedSizeEXT = 32808,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HISTOGRAM_GREEN_SIZE_EXT")]
    GreenSizeEXT = 32809,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HISTOGRAM_BLUE_SIZE_EXT")]
    BlueSizeEXT = 32810,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HISTOGRAM_ALPHA_SIZE_EXT")]
    AlphaSizeEXT = 32811,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HISTOGRAM_LUMINANCE_SIZE_EXT")]
    LuminanceSizeEXT = 32812,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HISTOGRAM_SINK_EXT")]
    SinkEXT = 32813,
}
