// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVA_VideoProcessCaps")]
    public enum VideoProcessCaps : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "DXVA_VideoProcess_None")]
        VideoProcessNone = 0x0,
        [Obsolete("Deprecated in favour of \"Yuv2Rgb\"")]
        [NativeName("Name", "DXVA_VideoProcess_YUV2RGB")]
        VideoProcessYuv2Rgb = 0x1,
        [Obsolete("Deprecated in favour of \"StretchX\"")]
        [NativeName("Name", "DXVA_VideoProcess_StretchX")]
        VideoProcessStretchX = 0x2,
        [Obsolete("Deprecated in favour of \"StretchY\"")]
        [NativeName("Name", "DXVA_VideoProcess_StretchY")]
        VideoProcessStretchY = 0x4,
        [Obsolete("Deprecated in favour of \"AlphaBlend\"")]
        [NativeName("Name", "DXVA_VideoProcess_AlphaBlend")]
        VideoProcessAlphaBlend = 0x8,
        [Obsolete("Deprecated in favour of \"SubRects\"")]
        [NativeName("Name", "DXVA_VideoProcess_SubRects")]
        VideoProcessSubRects = 0x10,
        [Obsolete("Deprecated in favour of \"SubStreams\"")]
        [NativeName("Name", "DXVA_VideoProcess_SubStreams")]
        VideoProcessSubStreams = 0x20,
        [Obsolete("Deprecated in favour of \"SubStreamsExtended\"")]
        [NativeName("Name", "DXVA_VideoProcess_SubStreamsExtended")]
        VideoProcessSubStreamsExtended = 0x40,
        [Obsolete("Deprecated in favour of \"Yuv2RgbExtended\"")]
        [NativeName("Name", "DXVA_VideoProcess_YUV2RGBExtended")]
        VideoProcessYuv2Rgbextended = 0x80,
        [Obsolete("Deprecated in favour of \"AlphaBlendExtended\"")]
        [NativeName("Name", "DXVA_VideoProcess_AlphaBlendExtended")]
        VideoProcessAlphaBlendExtended = 0x100,
        [NativeName("Name", "DXVA_VideoProcess_None")]
        None = 0x0,
        [NativeName("Name", "DXVA_VideoProcess_YUV2RGB")]
        Yuv2Rgb = 0x1,
        [NativeName("Name", "DXVA_VideoProcess_StretchX")]
        StretchX = 0x2,
        [NativeName("Name", "DXVA_VideoProcess_StretchY")]
        StretchY = 0x4,
        [NativeName("Name", "DXVA_VideoProcess_AlphaBlend")]
        AlphaBlend = 0x8,
        [NativeName("Name", "DXVA_VideoProcess_SubRects")]
        SubRects = 0x10,
        [NativeName("Name", "DXVA_VideoProcess_SubStreams")]
        SubStreams = 0x20,
        [NativeName("Name", "DXVA_VideoProcess_SubStreamsExtended")]
        SubStreamsExtended = 0x40,
        [NativeName("Name", "DXVA_VideoProcess_YUV2RGBExtended")]
        Yuv2RgbExtended = 0x80,
        [NativeName("Name", "DXVA_VideoProcess_AlphaBlendExtended")]
        AlphaBlendExtended = 0x100,
    }
}
