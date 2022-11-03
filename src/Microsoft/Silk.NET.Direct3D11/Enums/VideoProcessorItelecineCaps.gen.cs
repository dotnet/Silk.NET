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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Caps32\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_32")]
        VideoProcessorItelecineCaps32 = 0x1,
        [Obsolete("Deprecated in favour of \"Caps22\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_22")]
        VideoProcessorItelecineCaps22 = 0x2,
        [Obsolete("Deprecated in favour of \"Caps2224\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_2224")]
        VideoProcessorItelecineCaps2224 = 0x4,
        [Obsolete("Deprecated in favour of \"Caps2332\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_2332")]
        VideoProcessorItelecineCaps2332 = 0x8,
        [Obsolete("Deprecated in favour of \"Caps32322\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_32322")]
        VideoProcessorItelecineCaps32322 = 0x10,
        [Obsolete("Deprecated in favour of \"Caps55\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_55")]
        VideoProcessorItelecineCaps55 = 0x20,
        [Obsolete("Deprecated in favour of \"Caps64\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_64")]
        VideoProcessorItelecineCaps64 = 0x40,
        [Obsolete("Deprecated in favour of \"Caps87\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_87")]
        VideoProcessorItelecineCaps87 = 0x80,
        [Obsolete("Deprecated in favour of \"Caps222222222223\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_222222222223")]
        VideoProcessorItelecineCaps222222222223 = 0x100,
        [Obsolete("Deprecated in favour of \"CapsOther\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_OTHER")]
        VideoProcessorItelecineCapsOther = unchecked((int) 0xFFFFFFFF80000000),
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_32")]
        Caps32 = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_22")]
        Caps22 = 0x2,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_2224")]
        Caps2224 = 0x4,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_2332")]
        Caps2332 = 0x8,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_32322")]
        Caps32322 = 0x10,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_55")]
        Caps55 = 0x20,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_64")]
        Caps64 = 0x40,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_87")]
        Caps87 = 0x80,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_222222222223")]
        Caps222222222223 = 0x100,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ITELECINE_CAPS_OTHER")]
        CapsOther = unchecked((int) 0xFFFFFFFF80000000),
    }
}
