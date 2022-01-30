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
        [NativeName("Name", "DXVA2_VideoProcess_None")]
        DXVA2VideoProcessNone = 0x0,
        [NativeName("Name", "DXVA2_VideoProcess_YUV2RGB")]
        DXVA2VideoProcessYuv2Rgb = 0x1,
        [NativeName("Name", "DXVA2_VideoProcess_StretchX")]
        DXVA2VideoProcessStretchX = 0x2,
        [NativeName("Name", "DXVA2_VideoProcess_StretchY")]
        DXVA2VideoProcessStretchY = 0x4,
        [NativeName("Name", "DXVA2_VideoProcess_AlphaBlend")]
        DXVA2VideoProcessAlphaBlend = 0x8,
        [NativeName("Name", "DXVA2_VideoProcess_SubRects")]
        DXVA2VideoProcessSubRects = 0x10,
        [NativeName("Name", "DXVA2_VideoProcess_SubStreams")]
        DXVA2VideoProcessSubStreams = 0x20,
        [NativeName("Name", "DXVA2_VideoProcess_SubStreamsExtended")]
        DXVA2VideoProcessSubStreamsExtended = 0x40,
        [NativeName("Name", "DXVA2_VideoProcess_YUV2RGBExtended")]
        DXVA2VideoProcessYuv2Rgbextended = 0x80,
        [NativeName("Name", "DXVA2_VideoProcess_AlphaBlendExtended")]
        DXVA2VideoProcessAlphaBlendExtended = 0x100,
        [NativeName("Name", "DXVA2_VideoProcess_Constriction")]
        DXVA2VideoProcessConstriction = 0x200,
        [NativeName("Name", "DXVA2_VideoProcess_NoiseFilter")]
        DXVA2VideoProcessNoiseFilter = 0x400,
        [NativeName("Name", "DXVA2_VideoProcess_DetailFilter")]
        DXVA2VideoProcessDetailFilter = 0x800,
        [NativeName("Name", "DXVA2_VideoProcess_PlanarAlpha")]
        DXVA2VideoProcessPlanarAlpha = 0x1000,
        [NativeName("Name", "DXVA2_VideoProcess_LinearScaling")]
        DXVA2VideoProcessLinearScaling = 0x2000,
        [NativeName("Name", "DXVA2_VideoProcess_GammaCompensated")]
        DXVA2VideoProcessGammaCompensated = 0x4000,
        [NativeName("Name", "DXVA2_VideoProcess_MaintainsOriginalFieldData")]
        DXVA2VideoProcessMaintainsOriginalFieldData = 0x8000,
        [NativeName("Name", "DXVA2_VideoProcess_Mask")]
        DXVA2VideoProcessMask = 0xFFFF,
    }
}
