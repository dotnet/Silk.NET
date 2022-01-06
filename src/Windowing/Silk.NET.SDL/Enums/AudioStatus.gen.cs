// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_audio_L570_C9")]
    [NativeName("Name", "SDL_AudioStatus")]
    public enum AudioStatus : int
    {
        [NativeName("Name", "SDL_AUDIO_STOPPED")]
        AudioStopped = 0x0,
        [NativeName("Name", "SDL_AUDIO_PLAYING")]
        AudioPlaying = 0x1,
        [NativeName("Name", "SDL_AUDIO_PAUSED")]
        AudioPaused = 0x2,
    }
}
