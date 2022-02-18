// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_messagebox_L73_C9")]
    [NativeName("Name", "SDL_MessageBoxColorType")]
    public enum MessageBoxColorType : int
    {
        [NativeName("Name", "SDL_MESSAGEBOX_COLOR_BACKGROUND")]
        MessageboxColorBackground = 0x0,
        [NativeName("Name", "SDL_MESSAGEBOX_COLOR_TEXT")]
        MessageboxColorText = 0x1,
        [NativeName("Name", "SDL_MESSAGEBOX_COLOR_BUTTON_BORDER")]
        MessageboxColorButtonBorder = 0x2,
        [NativeName("Name", "SDL_MESSAGEBOX_COLOR_BUTTON_BACKGROUND")]
        MessageboxColorButtonBackground = 0x3,
        [NativeName("Name", "SDL_MESSAGEBOX_COLOR_BUTTON_SELECTED")]
        MessageboxColorButtonSelected = 0x4,
        [NativeName("Name", "SDL_MESSAGEBOX_COLOR_MAX")]
        MessageboxColorMax = 0x5,
    }
}
