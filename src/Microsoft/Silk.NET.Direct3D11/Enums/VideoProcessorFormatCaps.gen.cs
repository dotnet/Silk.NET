// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FORMAT_CAPS")]
    public enum VideoProcessorFormatCaps
    {
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FORMAT_CAPS_RGB_INTERLACED")]
        VideoProcessorFormatCapsRgbInterlaced = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FORMAT_CAPS_RGB_PROCAMP")]
        VideoProcessorFormatCapsRgbProcamp = 0x2,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FORMAT_CAPS_RGB_LUMA_KEY")]
        VideoProcessorFormatCapsRgbLumaKey = 0x4,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FORMAT_CAPS_PALETTE_INTERLACED")]
        VideoProcessorFormatCapsPaletteInterlaced = 0x8,
    }
}
