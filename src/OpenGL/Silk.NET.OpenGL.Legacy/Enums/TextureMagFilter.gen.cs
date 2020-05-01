// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    public enum TextureMagFilter
    {
        Nearest = 0x2600,
        Linear = 0x2601,
        LinearDetailSgis = 0x8097,
        LinearDetailAlphaSgis = 0x8098,
        LinearDetailColorSgis = 0x8099,
        LinearSharpenSgis = 0x80AD,
        LinearSharpenAlphaSgis = 0x80AE,
        LinearSharpenColorSgis = 0x80AF,
        Filter4Sgis = 0x8146,
        PixelTexGenQCeilingSgix = 0x8184,
        PixelTexGenQRoundSgix = 0x8185,
        PixelTexGenQFloorSgix = 0x8186,
    }
}
