// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_messagebox_L37_C9")]
    [NativeName("Name", "SDL_MessageBoxFlags")]
    public enum MessageBoxFlags : int
    {
        [NativeName("Name", "SDL_MESSAGEBOX_ERROR")]
        MessageboxError = 0x10,
        [NativeName("Name", "SDL_MESSAGEBOX_WARNING")]
        MessageboxWarning = 0x20,
        [NativeName("Name", "SDL_MESSAGEBOX_INFORMATION")]
        MessageboxInformation = 0x40,
        [NativeName("Name", "SDL_MESSAGEBOX_BUTTONS_LEFT_TO_RIGHT")]
        MessageboxButtonsLeftToRight = 0x80,
        [NativeName("Name", "SDL_MESSAGEBOX_BUTTONS_RIGHT_TO_LEFT")]
        MessageboxButtonsRightToLeft = 0x100,
    }
}
