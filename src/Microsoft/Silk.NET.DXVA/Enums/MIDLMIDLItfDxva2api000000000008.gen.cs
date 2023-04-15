// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "__MIDL___MIDL_itf_dxva2api_0000_0000_0008")]
    public enum MIDLMIDLItfDxva2api000000000008 : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "DXVA2_VideoProcess_None")]
        DXVA2VideoProcessNone = 0x0,
        [Obsolete("Deprecated in favour of \"Yuv2Rgb\"")]
        [NativeName("Name", "DXVA2_VideoProcess_YUV2RGB")]
        DXVA2VideoProcessYuv2Rgb = 0x1,
        [Obsolete("Deprecated in favour of \"StretchX\"")]
        [NativeName("Name", "DXVA2_VideoProcess_StretchX")]
        DXVA2VideoProcessStretchX = 0x2,
        [Obsolete("Deprecated in favour of \"StretchY\"")]
        [NativeName("Name", "DXVA2_VideoProcess_StretchY")]
        DXVA2VideoProcessStretchY = 0x4,
        [Obsolete("Deprecated in favour of \"AlphaBlend\"")]
        [NativeName("Name", "DXVA2_VideoProcess_AlphaBlend")]
        DXVA2VideoProcessAlphaBlend = 0x8,
        [Obsolete("Deprecated in favour of \"SubRects\"")]
        [NativeName("Name", "DXVA2_VideoProcess_SubRects")]
        DXVA2VideoProcessSubRects = 0x10,
        [Obsolete("Deprecated in favour of \"SubStreams\"")]
        [NativeName("Name", "DXVA2_VideoProcess_SubStreams")]
        DXVA2VideoProcessSubStreams = 0x20,
        [Obsolete("Deprecated in favour of \"SubStreamsExtended\"")]
        [NativeName("Name", "DXVA2_VideoProcess_SubStreamsExtended")]
        DXVA2VideoProcessSubStreamsExtended = 0x40,
        [Obsolete("Deprecated in favour of \"Yuv2RgbExtended\"")]
        [NativeName("Name", "DXVA2_VideoProcess_YUV2RGBExtended")]
        DXVA2VideoProcessYuv2Rgbextended = 0x80,
        [Obsolete("Deprecated in favour of \"AlphaBlendExtended\"")]
        [NativeName("Name", "DXVA2_VideoProcess_AlphaBlendExtended")]
        DXVA2VideoProcessAlphaBlendExtended = 0x100,
        [Obsolete("Deprecated in favour of \"Constriction\"")]
        [NativeName("Name", "DXVA2_VideoProcess_Constriction")]
        DXVA2VideoProcessConstriction = 0x200,
        [Obsolete("Deprecated in favour of \"NoiseFilter\"")]
        [NativeName("Name", "DXVA2_VideoProcess_NoiseFilter")]
        DXVA2VideoProcessNoiseFilter = 0x400,
        [Obsolete("Deprecated in favour of \"DetailFilter\"")]
        [NativeName("Name", "DXVA2_VideoProcess_DetailFilter")]
        DXVA2VideoProcessDetailFilter = 0x800,
        [Obsolete("Deprecated in favour of \"PlanarAlpha\"")]
        [NativeName("Name", "DXVA2_VideoProcess_PlanarAlpha")]
        DXVA2VideoProcessPlanarAlpha = 0x1000,
        [Obsolete("Deprecated in favour of \"LinearScaling\"")]
        [NativeName("Name", "DXVA2_VideoProcess_LinearScaling")]
        DXVA2VideoProcessLinearScaling = 0x2000,
        [Obsolete("Deprecated in favour of \"GammaCompensated\"")]
        [NativeName("Name", "DXVA2_VideoProcess_GammaCompensated")]
        DXVA2VideoProcessGammaCompensated = 0x4000,
        [Obsolete("Deprecated in favour of \"MaintainsOriginalFieldData\"")]
        [NativeName("Name", "DXVA2_VideoProcess_MaintainsOriginalFieldData")]
        DXVA2VideoProcessMaintainsOriginalFieldData = 0x8000,
        [Obsolete("Deprecated in favour of \"Mask\"")]
        [NativeName("Name", "DXVA2_VideoProcess_Mask")]
        DXVA2VideoProcessMask = 0xFFFF,
        [NativeName("Name", "DXVA2_VideoProcess_None")]
        None = 0x0,
        [NativeName("Name", "DXVA2_VideoProcess_YUV2RGB")]
        Yuv2Rgb = 0x1,
        [NativeName("Name", "DXVA2_VideoProcess_StretchX")]
        StretchX = 0x2,
        [NativeName("Name", "DXVA2_VideoProcess_StretchY")]
        StretchY = 0x4,
        [NativeName("Name", "DXVA2_VideoProcess_AlphaBlend")]
        AlphaBlend = 0x8,
        [NativeName("Name", "DXVA2_VideoProcess_SubRects")]
        SubRects = 0x10,
        [NativeName("Name", "DXVA2_VideoProcess_SubStreams")]
        SubStreams = 0x20,
        [NativeName("Name", "DXVA2_VideoProcess_SubStreamsExtended")]
        SubStreamsExtended = 0x40,
        [NativeName("Name", "DXVA2_VideoProcess_YUV2RGBExtended")]
        Yuv2RgbExtended = 0x80,
        [NativeName("Name", "DXVA2_VideoProcess_AlphaBlendExtended")]
        AlphaBlendExtended = 0x100,
        [NativeName("Name", "DXVA2_VideoProcess_Constriction")]
        Constriction = 0x200,
        [NativeName("Name", "DXVA2_VideoProcess_NoiseFilter")]
        NoiseFilter = 0x400,
        [NativeName("Name", "DXVA2_VideoProcess_DetailFilter")]
        DetailFilter = 0x800,
        [NativeName("Name", "DXVA2_VideoProcess_PlanarAlpha")]
        PlanarAlpha = 0x1000,
        [NativeName("Name", "DXVA2_VideoProcess_LinearScaling")]
        LinearScaling = 0x2000,
        [NativeName("Name", "DXVA2_VideoProcess_GammaCompensated")]
        GammaCompensated = 0x4000,
        [NativeName("Name", "DXVA2_VideoProcess_MaintainsOriginalFieldData")]
        MaintainsOriginalFieldData = 0x8000,
        [NativeName("Name", "DXVA2_VideoProcess_Mask")]
        Mask = 0xFFFF,
    }
}
