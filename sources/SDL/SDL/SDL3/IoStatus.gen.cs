// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_IOStatus")]
public enum IoStatus : uint
{
    [NativeName("SDL_IO_STATUS_READY")]
    Ready,

    [NativeName("SDL_IO_STATUS_ERROR")]
    Error,

    [NativeName("SDL_IO_STATUS_EOF")]
    Eof,

    [NativeName("SDL_IO_STATUS_NOT_READY")]
    NotReady,

    [NativeName("SDL_IO_STATUS_READONLY")]
    Readonly,

    [NativeName("SDL_IO_STATUS_WRITEONLY")]
    Writeonly,
}
