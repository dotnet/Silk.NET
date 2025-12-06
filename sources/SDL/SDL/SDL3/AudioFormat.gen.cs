// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_AudioFormat")]
public enum AudioFormat : uint
{
    [NativeName("SDL_AUDIO_UNKNOWN")]
    Unknown = 0,

    [NativeName("SDL_AUDIO_U8")]
    U8 = 8,

    [NativeName("SDL_AUDIO_S8")]
    S8 = 32776,

    [NativeName("SDL_AUDIO_S16LE")]
    S16Le = 32784,

    [NativeName("SDL_AUDIO_S16BE")]
    S16Be = 36880,

    [NativeName("SDL_AUDIO_S32LE")]
    S32Le = 32800,

    [NativeName("SDL_AUDIO_S32BE")]
    S32Be = 36896,

    [NativeName("SDL_AUDIO_F32LE")]
    F32Le = 33056,

    [NativeName("SDL_AUDIO_F32BE")]
    F32Be = 37152,

    [NativeName("SDL_AUDIO_S16")]
    S16 = S16Le,

    [NativeName("SDL_AUDIO_S32")]
    S32 = S32Le,

    [NativeName("SDL_AUDIO_F32")]
    F32 = F32Le,
}
