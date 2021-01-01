// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_pixels_L51_C9")]
    [NativeName("Name", "SDL_PixelType")]
    public enum PixelType : int
    {
        [NativeName("Name", "SDL_PIXELTYPE_UNKNOWN")]
        PixeltypeUnknown = 0x0,
        [NativeName("Name", "SDL_PIXELTYPE_INDEX1")]
        PixeltypeIndex1 = 0x1,
        [NativeName("Name", "SDL_PIXELTYPE_INDEX4")]
        PixeltypeIndex4 = 0x2,
        [NativeName("Name", "SDL_PIXELTYPE_INDEX8")]
        PixeltypeIndex8 = 0x3,
        [NativeName("Name", "SDL_PIXELTYPE_PACKED8")]
        PixeltypePacked8 = 0x4,
        [NativeName("Name", "SDL_PIXELTYPE_PACKED16")]
        PixeltypePacked16 = 0x5,
        [NativeName("Name", "SDL_PIXELTYPE_PACKED32")]
        PixeltypePacked32 = 0x6,
        [NativeName("Name", "SDL_PIXELTYPE_ARRAYU8")]
        PixeltypeArrayu8 = 0x7,
        [NativeName("Name", "SDL_PIXELTYPE_ARRAYU16")]
        PixeltypeArrayu16 = 0x8,
        [NativeName("Name", "SDL_PIXELTYPE_ARRAYU32")]
        PixeltypeArrayu32 = 0x9,
        [NativeName("Name", "SDL_PIXELTYPE_ARRAYF16")]
        PixeltypeArrayf16 = 0xA,
        [NativeName("Name", "SDL_PIXELTYPE_ARRAYF32")]
        PixeltypeArrayf32 = 0xB,
    }
}
