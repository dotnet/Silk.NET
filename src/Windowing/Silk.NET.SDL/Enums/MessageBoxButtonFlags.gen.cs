// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_messagebox_L49_C9")]
    [NativeName("Name", "SDL_MessageBoxButtonFlags")]
    public enum MessageBoxButtonFlags : int
    {
        [Obsolete("Deprecated in favour of \"ReturnkeyDefault\"")]
        [NativeName("Name", "SDL_MESSAGEBOX_BUTTON_RETURNKEY_DEFAULT")]
        MessageboxButtonReturnkeyDefault = 0x1,
        [Obsolete("Deprecated in favour of \"EscapekeyDefault\"")]
        [NativeName("Name", "SDL_MESSAGEBOX_BUTTON_ESCAPEKEY_DEFAULT")]
        MessageboxButtonEscapekeyDefault = 0x2,
        [NativeName("Name", "SDL_MESSAGEBOX_BUTTON_RETURNKEY_DEFAULT")]
        ReturnkeyDefault = 0x1,
        [NativeName("Name", "SDL_MESSAGEBOX_BUTTON_ESCAPEKEY_DEFAULT")]
        EscapekeyDefault = 0x2,
    }
}
