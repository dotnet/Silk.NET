// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_BlendOperation")]
public enum BlendOperation : uint
{
    [NativeName("SDL_BLENDOPERATION_ADD")]
    Add = 1,

    [NativeName("SDL_BLENDOPERATION_SUBTRACT")]
    Subtract = 2,

    [NativeName("SDL_BLENDOPERATION_REV_SUBTRACT")]
    RevSubtract = 3,

    [NativeName("SDL_BLENDOPERATION_MINIMUM")]
    Minimum = 4,

    [NativeName("SDL_BLENDOPERATION_MAXIMUM")]
    Maximum = 5,
}
