// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_PropertyType")]
public enum PropertyType : uint
{
    [NativeName("SDL_PROPERTY_TYPE_INVALID")]
    Invalid,

    [NativeName("SDL_PROPERTY_TYPE_POINTER")]
    Pointer,

    [NativeName("SDL_PROPERTY_TYPE_STRING")]
    String,

    [NativeName("SDL_PROPERTY_TYPE_NUMBER")]
    Number,

    [NativeName("SDL_PROPERTY_TYPE_FLOAT")]
    Float,

    [NativeName("SDL_PROPERTY_TYPE_BOOLEAN")]
    Boolean,
}
