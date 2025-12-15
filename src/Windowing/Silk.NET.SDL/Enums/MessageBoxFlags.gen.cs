// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("Name", "SDL_MessageBoxFlags")]
    public enum MessageBoxFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Error\"")]
        [NativeName("Name", "SDL_MESSAGEBOX_ERROR")]
        MessageboxError = 0x10,
        [Obsolete("Deprecated in favour of \"Warning\"")]
        [NativeName("Name", "SDL_MESSAGEBOX_WARNING")]
        MessageboxWarning = 0x20,
        [Obsolete("Deprecated in favour of \"Information\"")]
        [NativeName("Name", "SDL_MESSAGEBOX_INFORMATION")]
        MessageboxInformation = 0x40,
        [Obsolete("Deprecated in favour of \"ButtonsLeftToRight\"")]
        [NativeName("Name", "SDL_MESSAGEBOX_BUTTONS_LEFT_TO_RIGHT")]
        MessageboxButtonsLeftToRight = 0x80,
        [Obsolete("Deprecated in favour of \"ButtonsRightToLeft\"")]
        [NativeName("Name", "SDL_MESSAGEBOX_BUTTONS_RIGHT_TO_LEFT")]
        MessageboxButtonsRightToLeft = 0x100,
        [NativeName("Name", "SDL_MESSAGEBOX_ERROR")]
        Error = 0x10,
        [NativeName("Name", "SDL_MESSAGEBOX_WARNING")]
        Warning = 0x20,
        [NativeName("Name", "SDL_MESSAGEBOX_INFORMATION")]
        Information = 0x40,
        [NativeName("Name", "SDL_MESSAGEBOX_BUTTONS_LEFT_TO_RIGHT")]
        ButtonsLeftToRight = 0x80,
        [NativeName("Name", "SDL_MESSAGEBOX_BUTTONS_RIGHT_TO_LEFT")]
        ButtonsRightToLeft = 0x100,
    }
}
