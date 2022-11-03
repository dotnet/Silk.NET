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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Downsample\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_CAPS_DOWNSAMPLE")]
        VideoDecoderCapsDownsample = 0x1,
        [Obsolete("Deprecated in favour of \"NonRealTime\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_CAPS_NON_REAL_TIME")]
        VideoDecoderCapsNonRealTime = 0x2,
        [Obsolete("Deprecated in favour of \"DownsampleDynamic\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_CAPS_DOWNSAMPLE_DYNAMIC")]
        VideoDecoderCapsDownsampleDynamic = 0x4,
        [Obsolete("Deprecated in favour of \"DownsampleRequired\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_CAPS_DOWNSAMPLE_REQUIRED")]
        VideoDecoderCapsDownsampleRequired = 0x8,
        [Obsolete("Deprecated in favour of \"Unsupported\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_CAPS_UNSUPPORTED")]
        VideoDecoderCapsUnsupported = 0x10,
        [NativeName("Name", "D3D11_VIDEO_DECODER_CAPS_DOWNSAMPLE")]
        Downsample = 0x1,
        [NativeName("Name", "D3D11_VIDEO_DECODER_CAPS_NON_REAL_TIME")]
        NonRealTime = 0x2,
        [NativeName("Name", "D3D11_VIDEO_DECODER_CAPS_DOWNSAMPLE_DYNAMIC")]
        DownsampleDynamic = 0x4,
        [NativeName("Name", "D3D11_VIDEO_DECODER_CAPS_DOWNSAMPLE_REQUIRED")]
        DownsampleRequired = 0x8,
        [NativeName("Name", "D3D11_VIDEO_DECODER_CAPS_UNSUPPORTED")]
        Unsupported = 0x10,
    }
}
