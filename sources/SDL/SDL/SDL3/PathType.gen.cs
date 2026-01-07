// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_PathType")]
public enum PathType
{
    [NativeName("SDL_PATHTYPE_NONE")]
    None = 0,

    [NativeName("SDL_PATHTYPE_FILE")]
    File = 1,

    [NativeName("SDL_PATHTYPE_DIRECTORY")]
    Directory = 2,

    [NativeName("SDL_PATHTYPE_OTHER")]
    Other = 3,
}
