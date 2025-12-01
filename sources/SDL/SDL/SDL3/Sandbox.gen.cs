// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_Sandbox")]
public enum Sandbox : uint
{
    [NativeName("SDL_SANDBOX_NONE")]
    None = 0,

    [NativeName("SDL_SANDBOX_UNKNOWN_CONTAINER")]
    UnknownContainer,

    [NativeName("SDL_SANDBOX_FLATPAK")]
    Flatpak,

    [NativeName("SDL_SANDBOX_SNAP")]
    Snap,

    [NativeName("SDL_SANDBOX_MACOS")]
    Macos,
}
