// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_FlashOperation")]
public enum FlashOperation
{
    [NativeName("SDL_FLASH_CANCEL")]
    Cancel = 0,

    [NativeName("SDL_FLASH_BRIEFLY")]
    Briefly = 1,

    [NativeName("SDL_FLASH_UNTIL_FOCUSED")]
    UntilFocused = 2,
}
