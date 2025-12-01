// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_TextInputType")]
public enum TextInputType : uint
{
    [NativeName("SDL_TEXTINPUT_TYPE_TEXT")]
    Text,

    [NativeName("SDL_TEXTINPUT_TYPE_TEXT_NAME")]
    TextName,

    [NativeName("SDL_TEXTINPUT_TYPE_TEXT_EMAIL")]
    TextEmail,

    [NativeName("SDL_TEXTINPUT_TYPE_TEXT_USERNAME")]
    TextUsername,

    [NativeName("SDL_TEXTINPUT_TYPE_TEXT_PASSWORD_HIDDEN")]
    TextPasswordHidden,

    [NativeName("SDL_TEXTINPUT_TYPE_TEXT_PASSWORD_VISIBLE")]
    TextPasswordVisible,

    [NativeName("SDL_TEXTINPUT_TYPE_NUMBER")]
    Number,

    [NativeName("SDL_TEXTINPUT_TYPE_NUMBER_PASSWORD_HIDDEN")]
    NumberPasswordHidden,

    [NativeName("SDL_TEXTINPUT_TYPE_NUMBER_PASSWORD_VISIBLE")]
    NumberPasswordVisible,
}
