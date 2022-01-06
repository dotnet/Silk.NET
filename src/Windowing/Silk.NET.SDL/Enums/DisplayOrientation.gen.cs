// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_video_L190_C9")]
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
