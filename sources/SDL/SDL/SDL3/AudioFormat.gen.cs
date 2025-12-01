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
    Unknown = 0x0000U,

    [NativeName("SDL_AUDIO_U8")]
    U8 = 0x0008U,

    [NativeName("SDL_AUDIO_S8")]
    S8 = 0x8008U,

    [NativeName("SDL_AUDIO_S16LE")]
    S16Le = 0x8010U,

    [NativeName("SDL_AUDIO_S16BE")]
    S16Be = 0x9010U,

    [NativeName("SDL_AUDIO_S32LE")]
    S32Le = 0x8020U,

    [NativeName("SDL_AUDIO_S32BE")]
    S32Be = 0x9020U,

    [NativeName("SDL_AUDIO_F32LE")]
    F32Le = 0x8120U,

    [NativeName("SDL_AUDIO_F32BE")]
    F32Be = 0x9120U,

    [NativeName("SDL_AUDIO_S16")]
    S16 = S16Le,

    [NativeName("SDL_AUDIO_S32")]
    S32 = S32Le,

    [NativeName("SDL_AUDIO_F32")]
    F32 = F32Le,
}
