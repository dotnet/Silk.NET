// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_messagebox_L49_C9")]
    [NativeName("Name", "SDL_MessageBoxButtonFlags")]
    public enum MessageBoxButtonFlags : int
    {
        [NativeName("Name", "SDL_MESSAGEBOX_BUTTON_RETURNKEY_DEFAULT")]
        MessageboxButtonReturnkeyDefault = 0x1,
        [NativeName("Name", "SDL_MESSAGEBOX_BUTTON_ESCAPEKEY_DEFAULT")]
        MessageboxButtonEscapekeyDefault = 0x2,
    }
}
