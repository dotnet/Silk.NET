// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_MessageBoxColorType")]
public enum MessageBoxColorType : uint
{
    [NativeName("SDL_MESSAGEBOX_COLOR_BACKGROUND")]
    Background,

    [NativeName("SDL_MESSAGEBOX_COLOR_TEXT")]
    Text,

    [NativeName("SDL_MESSAGEBOX_COLOR_BUTTON_BORDER")]
    ButtonBorder,

    [NativeName("SDL_MESSAGEBOX_COLOR_BUTTON_BACKGROUND")]
    ButtonBackground,

    [NativeName("SDL_MESSAGEBOX_COLOR_BUTTON_SELECTED")]
    ButtonSelected,

    [NativeName("SDL_MESSAGEBOX_COLOR_COUNT")]
    Count,
}
