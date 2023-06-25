// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_video_L209_C9")]
    [NativeName("Name", "SDL_FlashOperation")]
    public enum FlashOperation : int
    {
        [Obsolete("Deprecated in favour of \"Cancel\"")]
        [NativeName("Name", "SDL_FLASH_CANCEL")]
        FlashCancel = 0x0,
        [Obsolete("Deprecated in favour of \"Briefly\"")]
        [NativeName("Name", "SDL_FLASH_BRIEFLY")]
        FlashBriefly = 0x1,
        [Obsolete("Deprecated in favour of \"UntilFocused\"")]
        [NativeName("Name", "SDL_FLASH_UNTIL_FOCUSED")]
        FlashUntilFocused = 0x2,
        [NativeName("Name", "SDL_FLASH_CANCEL")]
        Cancel = 0x0,
        [NativeName("Name", "SDL_FLASH_BRIEFLY")]
        Briefly = 0x1,
        [NativeName("Name", "SDL_FLASH_UNTIL_FOCUSED")]
        UntilFocused = 0x2,
    }
}
