// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.HI
{
    [NativeName("Name", "GLenum")]
    public enum HI : int
    {
        [NativeName("Name", "EGL_CLIENT_PIXMAP_POINTER_HI")]
        ClientPixmapPointerHI = 0x8F74,
        [NativeName("Name", "EGL_COLOR_FORMAT_HI")]
        ColorFormatHI = 0x8F70,
        [NativeName("Name", "EGL_COLOR_RGB_HI")]
        ColorRgbHI = 0x8F71,
        [NativeName("Name", "EGL_COLOR_RGBA_HI")]
        ColorRgbaHI = 0x8F72,
        [NativeName("Name", "EGL_COLOR_ARGB_HI")]
        ColorArgbHI = 0x8F73,
    }
}
