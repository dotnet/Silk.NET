// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "GetHistogramParameterPNameEXT")]
    public enum GetHistogramParameterPNameEXT : int
    {
        [Obsolete("Deprecated in favour of \"Width\"")]
        [NativeName("Name", "GL_HISTOGRAM_WIDTH")]
        HistogramWidth = 0x8026,
        [Obsolete("Deprecated in favour of \"WidthExt\"")]
        [NativeName("Name", "GL_HISTOGRAM_WIDTH_EXT")]
        HistogramWidthExt = 0x8026,
        [Obsolete("Deprecated in favour of \"Format\"")]
        [NativeName("Name", "GL_HISTOGRAM_FORMAT")]
        HistogramFormat = 0x8027,
        [Obsolete("Deprecated in favour of \"FormatExt\"")]
        [NativeName("Name", "GL_HISTOGRAM_FORMAT_EXT")]
        HistogramFormatExt = 0x8027,
        [Obsolete("Deprecated in favour of \"RedSize\"")]
        [NativeName("Name", "GL_HISTOGRAM_RED_SIZE")]
        HistogramRedSize = 0x8028,
        [Obsolete("Deprecated in favour of \"RedSizeExt\"")]
        [NativeName("Name", "GL_HISTOGRAM_RED_SIZE_EXT")]
        HistogramRedSizeExt = 0x8028,
        [Obsolete("Deprecated in favour of \"GreenSize\"")]
        [NativeName("Name", "GL_HISTOGRAM_GREEN_SIZE")]
        HistogramGreenSize = 0x8029,
        [Obsolete("Deprecated in favour of \"GreenSizeExt\"")]
        [NativeName("Name", "GL_HISTOGRAM_GREEN_SIZE_EXT")]
        HistogramGreenSizeExt = 0x8029,
        [Obsolete("Deprecated in favour of \"BlueSize\"")]
        [NativeName("Name", "GL_HISTOGRAM_BLUE_SIZE")]
        HistogramBlueSize = 0x802A,
        [Obsolete("Deprecated in favour of \"BlueSizeExt\"")]
        [NativeName("Name", "GL_HISTOGRAM_BLUE_SIZE_EXT")]
        HistogramBlueSizeExt = 0x802A,
        [Obsolete("Deprecated in favour of \"AlphaSize\"")]
        [NativeName("Name", "GL_HISTOGRAM_ALPHA_SIZE")]
        HistogramAlphaSize = 0x802B,
        [Obsolete("Deprecated in favour of \"AlphaSizeExt\"")]
        [NativeName("Name", "GL_HISTOGRAM_ALPHA_SIZE_EXT")]
        HistogramAlphaSizeExt = 0x802B,
        [Obsolete("Deprecated in favour of \"LuminanceSize\"")]
        [NativeName("Name", "GL_HISTOGRAM_LUMINANCE_SIZE")]
        HistogramLuminanceSize = 0x802C,
        [Obsolete("Deprecated in favour of \"LuminanceSizeExt\"")]
        [NativeName("Name", "GL_HISTOGRAM_LUMINANCE_SIZE_EXT")]
        HistogramLuminanceSizeExt = 0x802C,
        [Obsolete("Deprecated in favour of \"Sink\"")]
        [NativeName("Name", "GL_HISTOGRAM_SINK")]
        HistogramSink = 0x802D,
        [Obsolete("Deprecated in favour of \"SinkExt\"")]
        [NativeName("Name", "GL_HISTOGRAM_SINK_EXT")]
        HistogramSinkExt = 0x802D,
        [NativeName("Name", "GL_HISTOGRAM_WIDTH")]
        Width = 0x8026,
        [NativeName("Name", "GL_HISTOGRAM_WIDTH_EXT")]
        WidthExt = 0x8026,
        [NativeName("Name", "GL_HISTOGRAM_FORMAT")]
        Format = 0x8027,
        [NativeName("Name", "GL_HISTOGRAM_FORMAT_EXT")]
        FormatExt = 0x8027,
        [NativeName("Name", "GL_HISTOGRAM_RED_SIZE")]
        RedSize = 0x8028,
        [NativeName("Name", "GL_HISTOGRAM_RED_SIZE_EXT")]
        RedSizeExt = 0x8028,
        [NativeName("Name", "GL_HISTOGRAM_GREEN_SIZE")]
        GreenSize = 0x8029,
        [NativeName("Name", "GL_HISTOGRAM_GREEN_SIZE_EXT")]
        GreenSizeExt = 0x8029,
        [NativeName("Name", "GL_HISTOGRAM_BLUE_SIZE")]
        BlueSize = 0x802A,
        [NativeName("Name", "GL_HISTOGRAM_BLUE_SIZE_EXT")]
        BlueSizeExt = 0x802A,
        [NativeName("Name", "GL_HISTOGRAM_ALPHA_SIZE")]
        AlphaSize = 0x802B,
        [NativeName("Name", "GL_HISTOGRAM_ALPHA_SIZE_EXT")]
        AlphaSizeExt = 0x802B,
        [NativeName("Name", "GL_HISTOGRAM_LUMINANCE_SIZE")]
        LuminanceSize = 0x802C,
        [NativeName("Name", "GL_HISTOGRAM_LUMINANCE_SIZE_EXT")]
        LuminanceSizeExt = 0x802C,
        [NativeName("Name", "GL_HISTOGRAM_SINK")]
        Sink = 0x802D,
        [NativeName("Name", "GL_HISTOGRAM_SINK_EXT")]
        SinkExt = 0x802D,
    }
}
