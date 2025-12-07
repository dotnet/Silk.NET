// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_TextInputType")]
public enum TextInputType
{
    [NativeName("SDL_TEXTINPUT_TYPE_TEXT")]
    Text = 0,

    [NativeName("SDL_TEXTINPUT_TYPE_TEXT_NAME")]
    TextName = 1,

    [NativeName("SDL_TEXTINPUT_TYPE_TEXT_EMAIL")]
    TextEmail = 2,

    [NativeName("SDL_TEXTINPUT_TYPE_TEXT_USERNAME")]
    TextUsername = 3,

    [NativeName("SDL_TEXTINPUT_TYPE_TEXT_PASSWORD_HIDDEN")]
    TextPasswordHidden = 4,

    [NativeName("SDL_TEXTINPUT_TYPE_TEXT_PASSWORD_VISIBLE")]
    TextPasswordVisible = 5,

    [NativeName("SDL_TEXTINPUT_TYPE_NUMBER")]
    Number = 6,

    [NativeName("SDL_TEXTINPUT_TYPE_NUMBER_PASSWORD_HIDDEN")]
    NumberPasswordHidden = 7,

    [NativeName("SDL_TEXTINPUT_TYPE_NUMBER_PASSWORD_VISIBLE")]
    NumberPasswordVisible = 8,
}
