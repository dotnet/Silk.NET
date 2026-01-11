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
    Srgb = 301991328,

    [NativeName("SDL_COLORSPACE_SRGB_LINEAR")]
    SrgbLinear = 301991168,

    [NativeName("SDL_COLORSPACE_HDR10")]
    Hdr10 = 301999616,

    [NativeName("SDL_COLORSPACE_JPEG")]
    Jpeg = 570426566,

    [NativeName("SDL_COLORSPACE_BT601_LIMITED")]
    Bt601Limited = 554703046,

    [NativeName("SDL_COLORSPACE_BT601_FULL")]
    Bt601Full = 571480262,

    [NativeName("SDL_COLORSPACE_BT709_LIMITED")]
    Bt709Limited = 554697761,

    [NativeName("SDL_COLORSPACE_BT709_FULL")]
    Bt709Full = 571474977,

    [NativeName("SDL_COLORSPACE_BT2020_LIMITED")]
    Bt2020Limited = 554706441,

    [NativeName("SDL_COLORSPACE_BT2020_FULL")]
    Bt2020Full = 571483657,

    [NativeName("SDL_COLORSPACE_RGB_DEFAULT")]
    RgbDefault = Srgb,

    [NativeName("SDL_COLORSPACE_YUV_DEFAULT")]
    YuvDefault = Jpeg,
}
