// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_RendererLogicalPresentation")]
public enum RendererLogicalPresentation : uint
{
    [NativeName("SDL_LOGICAL_PRESENTATION_DISABLED")]
    Disabled = 0,

    [NativeName("SDL_LOGICAL_PRESENTATION_STRETCH")]
    Stretch = 1,

    [NativeName("SDL_LOGICAL_PRESENTATION_LETTERBOX")]
    Letterbox = 2,

    [NativeName("SDL_LOGICAL_PRESENTATION_OVERSCAN")]
    Overscan = 3,

    [NativeName("SDL_LOGICAL_PRESENTATION_INTEGER_SCALE")]
    IntegerScale = 4,
}
