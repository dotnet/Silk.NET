// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FORMAT_CAPS")]
    public enum VideoProcessorFormatCaps : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"RgbInterlaced\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FORMAT_CAPS_RGB_INTERLACED")]
        VideoProcessorFormatCapsRgbInterlaced = 0x1,
        [Obsolete("Deprecated in favour of \"RgbProcamp\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FORMAT_CAPS_RGB_PROCAMP")]
        VideoProcessorFormatCapsRgbProcamp = 0x2,
        [Obsolete("Deprecated in favour of \"RgbLumaKey\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FORMAT_CAPS_RGB_LUMA_KEY")]
        VideoProcessorFormatCapsRgbLumaKey = 0x4,
        [Obsolete("Deprecated in favour of \"PaletteInterlaced\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FORMAT_CAPS_PALETTE_INTERLACED")]
        VideoProcessorFormatCapsPaletteInterlaced = 0x8,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FORMAT_CAPS_RGB_INTERLACED")]
        RgbInterlaced = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FORMAT_CAPS_RGB_PROCAMP")]
        RgbProcamp = 0x2,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FORMAT_CAPS_RGB_LUMA_KEY")]
        RgbLumaKey = 0x4,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FORMAT_CAPS_PALETTE_INTERLACED")]
        PaletteInterlaced = 0x8,
    }
}
