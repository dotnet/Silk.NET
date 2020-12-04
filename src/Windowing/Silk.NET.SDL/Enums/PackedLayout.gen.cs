// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_pixels_L104_C9")]
    [NativeName("Name", "SDL_PackedLayout")]
    public enum PackedLayout
    {
        [NativeName("Name", "SDL_PACKEDLAYOUT_NONE")]
        PackedlayoutNone = 0x0,
        [NativeName("Name", "SDL_PACKEDLAYOUT_332")]
        Packedlayout332 = 0x1,
        [NativeName("Name", "SDL_PACKEDLAYOUT_4444")]
        Packedlayout4444 = 0x2,
        [NativeName("Name", "SDL_PACKEDLAYOUT_1555")]
        Packedlayout1555 = 0x3,
        [NativeName("Name", "SDL_PACKEDLAYOUT_5551")]
        Packedlayout5551 = 0x4,
        [NativeName("Name", "SDL_PACKEDLAYOUT_565")]
        Packedlayout565 = 0x5,
        [NativeName("Name", "SDL_PACKEDLAYOUT_8888")]
        Packedlayout8888 = 0x6,
        [NativeName("Name", "SDL_PACKEDLAYOUT_2101010")]
        Packedlayout2101010 = 0x7,
        [NativeName("Name", "SDL_PACKEDLAYOUT_1010102")]
        Packedlayout1010102 = 0x8,
    }
}
