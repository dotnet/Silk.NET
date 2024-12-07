// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeTypeName("unsigned int")]
public enum Colorspace : uint
{
    Unknown = 0,
    Srgb = 0x120005a0U,
    SrgbLinear = 0x12000500U,
    Hdr10 = 0x12002600U,
    Jpeg = 0x220004c6U,
    Bt601Limited = 0x211018c6U,
    Bt601Full = 0x221018c6U,
    Bt709Limited = 0x21100421U,
    Bt709Full = 0x22100421U,
    Bt2020Limited = 0x21102609U,
    Bt2020Full = 0x22102609U,
    RgbDefault = Srgb,
    YuvDefault = Jpeg,
}
