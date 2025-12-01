// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("GetHistogramParameterPNameEXT")]
public enum GetHistogramParameterPNameEXT : uint
{
    [NativeName("GL_HISTOGRAM_WIDTH")]
    Width = unchecked((uint)0x8026),

    [NativeName("GL_HISTOGRAM_FORMAT")]
    Format = unchecked((uint)0x8027),

    [NativeName("GL_HISTOGRAM_RED_SIZE")]
    RedSize = unchecked((uint)0x8028),

    [NativeName("GL_HISTOGRAM_GREEN_SIZE")]
    GreenSize = unchecked((uint)0x8029),

    [NativeName("GL_HISTOGRAM_BLUE_SIZE")]
    BlueSize = unchecked((uint)0x802A),

    [NativeName("GL_HISTOGRAM_ALPHA_SIZE")]
    AlphaSize = unchecked((uint)0x802B),

    [NativeName("GL_HISTOGRAM_LUMINANCE_SIZE")]
    LuminanceSize = unchecked((uint)0x802C),

    [NativeName("GL_HISTOGRAM_SINK")]
    Sink = unchecked((uint)0x802D),

    [NativeName("GL_HISTOGRAM_WIDTH_EXT")]
    WidthEXT = unchecked((uint)0x8026),

    [NativeName("GL_HISTOGRAM_FORMAT_EXT")]
    FormatEXT = unchecked((uint)0x8027),

    [NativeName("GL_HISTOGRAM_RED_SIZE_EXT")]
    RedSizeEXT = unchecked((uint)0x8028),

    [NativeName("GL_HISTOGRAM_GREEN_SIZE_EXT")]
    GreenSizeEXT = unchecked((uint)0x8029),

    [NativeName("GL_HISTOGRAM_BLUE_SIZE_EXT")]
    BlueSizeEXT = unchecked((uint)0x802A),

    [NativeName("GL_HISTOGRAM_ALPHA_SIZE_EXT")]
    AlphaSizeEXT = unchecked((uint)0x802B),

    [NativeName("GL_HISTOGRAM_LUMINANCE_SIZE_EXT")]
    LuminanceSizeEXT = unchecked((uint)0x802C),

    [NativeName("GL_HISTOGRAM_SINK_EXT")]
    SinkEXT = unchecked((uint)0x802D),
}
