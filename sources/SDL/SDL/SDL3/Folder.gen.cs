// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_Folder")]
public enum Folder
{
    [NativeName("SDL_FOLDER_HOME")]
    Home = 0,

    [NativeName("SDL_FOLDER_DESKTOP")]
    Desktop = 1,

    [NativeName("SDL_FOLDER_DOCUMENTS")]
    Documents = 2,

    [NativeName("SDL_FOLDER_DOWNLOADS")]
    Downloads = 3,

    [NativeName("SDL_FOLDER_MUSIC")]
    Music = 4,

    [NativeName("SDL_FOLDER_PICTURES")]
    Pictures = 5,

    [NativeName("SDL_FOLDER_PUBLICSHARE")]
    Publicshare = 6,

    [NativeName("SDL_FOLDER_SAVEDGAMES")]
    Savedgames = 7,

    [NativeName("SDL_FOLDER_SCREENSHOTS")]
    Screenshots = 8,

    [NativeName("SDL_FOLDER_TEMPLATES")]
    Templates = 9,

    [NativeName("SDL_FOLDER_VIDEOS")]
    Videos = 10,

    [NativeName("SDL_FOLDER_COUNT")]
    Count = 11,
}
