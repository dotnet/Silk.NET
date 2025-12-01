// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_Colorspace")]
public enum Colorspace : uint
{
    [NativeName("SDL_COLORSPACE_UNKNOWN")]
    Unknown = 0,

    [NativeName("SDL_COLORSPACE_SRGB")]
    Srgb = 0x120005a0U,

    [NativeName("SDL_COLORSPACE_SRGB_LINEAR")]
    SrgbLinear = 0x12000500U,

    [NativeName("SDL_COLORSPACE_HDR10")]
    Hdr10 = 0x12002600U,

    [NativeName("SDL_COLORSPACE_JPEG")]
    Jpeg = 0x220004c6U,

    [NativeName("SDL_COLORSPACE_BT601_LIMITED")]
    Bt601Limited = 0x211018c6U,

    [NativeName("SDL_COLORSPACE_BT601_FULL")]
    Bt601Full = 0x221018c6U,

    [NativeName("SDL_COLORSPACE_BT709_LIMITED")]
    Bt709Limited = 0x21100421U,

    [NativeName("SDL_COLORSPACE_BT709_FULL")]
    Bt709Full = 0x22100421U,

    [NativeName("SDL_COLORSPACE_BT2020_LIMITED")]
    Bt2020Limited = 0x21102609U,

    [NativeName("SDL_COLORSPACE_BT2020_FULL")]
    Bt2020Full = 0x22102609U,

    [NativeName("SDL_COLORSPACE_RGB_DEFAULT")]
    RgbDefault = Srgb,

    [NativeName("SDL_COLORSPACE_YUV_DEFAULT")]
    YuvDefault = Jpeg,
}
