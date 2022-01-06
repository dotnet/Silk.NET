// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVAHD_INPUT_FORMAT_CAPS")]
    public enum HDInputFormatCaps : int
    {
        [NativeName("Name", "DXVAHD_INPUT_FORMAT_CAPS_RGB_INTERLACED")]
        HDInputFormatCapsRgbInterlaced = 0x1,
        [NativeName("Name", "DXVAHD_INPUT_FORMAT_CAPS_RGB_PROCAMP")]
        HDInputFormatCapsRgbProcamp = 0x2,
        [NativeName("Name", "DXVAHD_INPUT_FORMAT_CAPS_RGB_LUMA_KEY")]
        HDInputFormatCapsRgbLumaKey = 0x4,
        [NativeName("Name", "DXVAHD_INPUT_FORMAT_CAPS_PALETTE_INTERLACED")]
        HDInputFormatCapsPaletteInterlaced = 0x8,
    }
}
