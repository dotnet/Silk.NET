// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "GetHistogramParameterPNameEXT")]
    public enum GetHistogramParameterPNameEXT : int
    {
        [NativeName("Name", "GL_HISTOGRAM_WIDTH")]
        HistogramWidth = 0x8026,
        [NativeName("Name", "GL_HISTOGRAM_WIDTH_EXT")]
        HistogramWidthExt = 0x8026,
        [NativeName("Name", "GL_HISTOGRAM_FORMAT")]
        HistogramFormat = 0x8027,
        [NativeName("Name", "GL_HISTOGRAM_FORMAT_EXT")]
        HistogramFormatExt = 0x8027,
        [NativeName("Name", "GL_HISTOGRAM_RED_SIZE")]
        HistogramRedSize = 0x8028,
        [NativeName("Name", "GL_HISTOGRAM_RED_SIZE_EXT")]
        HistogramRedSizeExt = 0x8028,
        [NativeName("Name", "GL_HISTOGRAM_GREEN_SIZE")]
        HistogramGreenSize = 0x8029,
        [NativeName("Name", "GL_HISTOGRAM_GREEN_SIZE_EXT")]
        HistogramGreenSizeExt = 0x8029,
        [NativeName("Name", "GL_HISTOGRAM_BLUE_SIZE")]
        HistogramBlueSize = 0x802A,
        [NativeName("Name", "GL_HISTOGRAM_BLUE_SIZE_EXT")]
        HistogramBlueSizeExt = 0x802A,
        [NativeName("Name", "GL_HISTOGRAM_ALPHA_SIZE")]
        HistogramAlphaSize = 0x802B,
        [NativeName("Name", "GL_HISTOGRAM_ALPHA_SIZE_EXT")]
        HistogramAlphaSizeExt = 0x802B,
        [NativeName("Name", "GL_HISTOGRAM_LUMINANCE_SIZE")]
        HistogramLuminanceSize = 0x802C,
        [NativeName("Name", "GL_HISTOGRAM_LUMINANCE_SIZE_EXT")]
        HistogramLuminanceSizeExt = 0x802C,
        [NativeName("Name", "GL_HISTOGRAM_SINK")]
        HistogramSink = 0x802D,
        [NativeName("Name", "GL_HISTOGRAM_SINK_EXT")]
        HistogramSinkExt = 0x802D,
    }
}
