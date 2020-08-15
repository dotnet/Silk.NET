// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_messagebox_L37_C9")]
    [NativeName("Name", "SDL_MessageBoxFlags")]
    public enum MessageBoxFlags
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
