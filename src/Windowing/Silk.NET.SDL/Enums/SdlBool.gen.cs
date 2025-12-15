// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_stdinc_L180_C9")]
    [NativeName("Name", "SDL_bool")]
    public enum SdlBool : int
    {
        [NativeName("Name", "SDL_FALSE")]
        False = 0x0,
        [NativeName("Name", "SDL_TRUE")]
        True = 0x1,
    }
}
