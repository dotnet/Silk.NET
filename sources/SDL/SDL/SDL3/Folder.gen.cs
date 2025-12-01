// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_Folder")]
public enum Folder : uint
{
    [NativeName("SDL_FOLDER_HOME")]
    Home,

    [NativeName("SDL_FOLDER_DESKTOP")]
    Desktop,

    [NativeName("SDL_FOLDER_DOCUMENTS")]
    Documents,

    [NativeName("SDL_FOLDER_DOWNLOADS")]
    Downloads,

    [NativeName("SDL_FOLDER_MUSIC")]
    Music,

    [NativeName("SDL_FOLDER_PICTURES")]
    Pictures,

    [NativeName("SDL_FOLDER_PUBLICSHARE")]
    Publicshare,

    [NativeName("SDL_FOLDER_SAVEDGAMES")]
    Savedgames,

    [NativeName("SDL_FOLDER_SCREENSHOTS")]
    Screenshots,

    [NativeName("SDL_FOLDER_TEMPLATES")]
    Templates,

    [NativeName("SDL_FOLDER_VIDEOS")]
    Videos,

    [NativeName("SDL_FOLDER_COUNT")]
    Count,
}
