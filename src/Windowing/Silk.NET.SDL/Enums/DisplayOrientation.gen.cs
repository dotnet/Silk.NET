// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_video_L180_C9")]
    [NativeName("Name", "SDL_DisplayOrientation")]
    public enum DisplayOrientation : int
    {
        [NativeName("Name", "SDL_ORIENTATION_UNKNOWN")]
        OrientationUnknown = 0x0,
        [NativeName("Name", "SDL_ORIENTATION_LANDSCAPE")]
        OrientationLandscape = 0x1,
        [NativeName("Name", "SDL_ORIENTATION_LANDSCAPE_FLIPPED")]
        OrientationLandscapeFlipped = 0x2,
        [NativeName("Name", "SDL_ORIENTATION_PORTRAIT")]
        OrientationPortrait = 0x3,
        [NativeName("Name", "SDL_ORIENTATION_PORTRAIT_FLIPPED")]
        OrientationPortraitFlipped = 0x4,
    }
}
