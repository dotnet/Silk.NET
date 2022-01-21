// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS")]
    public enum VideoProcessorItelecineCaps : int
    {
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_32")]
        VideoProcessorItelecineCaps32 = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_22")]
        VideoProcessorItelecineCaps22 = 0x2,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_2224")]
        VideoProcessorItelecineCaps2224 = 0x4,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_2332")]
        VideoProcessorItelecineCaps2332 = 0x8,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_32322")]
        VideoProcessorItelecineCaps32322 = 0x10,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_55")]
        VideoProcessorItelecineCaps55 = 0x20,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_64")]
        VideoProcessorItelecineCaps64 = 0x40,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_87")]
        VideoProcessorItelecineCaps87 = 0x80,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_222222222223")]
        VideoProcessorItelecineCaps222222222223 = 0x100,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_OTHER")]
        VideoProcessorItelecineCapsOther = unchecked((int) 0xFFFFFFFF80000000),
    }
}
