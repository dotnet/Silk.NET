// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_VIDEO_DECODER_CAPS")]
    public enum VideoDecoderCaps : int
    {
        [NativeName("Name", "D3D11_VIDEO_DECODER_CAPS_DOWNSAMPLE")]
        VideoDecoderCapsDownsample = 0x1,
        [NativeName("Name", "D3D11_VIDEO_DECODER_CAPS_NON_REAL_TIME")]
        VideoDecoderCapsNonRealTime = 0x2,
        [NativeName("Name", "D3D11_VIDEO_DECODER_CAPS_DOWNSAMPLE_DYNAMIC")]
        VideoDecoderCapsDownsampleDynamic = 0x4,
        [NativeName("Name", "D3D11_VIDEO_DECODER_CAPS_DOWNSAMPLE_REQUIRED")]
        VideoDecoderCapsDownsampleRequired = 0x8,
        [NativeName("Name", "D3D11_VIDEO_DECODER_CAPS_UNSUPPORTED")]
        VideoDecoderCapsUnsupported = 0x10,
    }
}
