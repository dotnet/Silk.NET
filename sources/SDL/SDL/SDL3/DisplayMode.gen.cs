// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
namespace Silk.NET.SDL;

[NativeName("SDL_DisplayMode")]
public unsafe partial struct DisplayMode
{
    [NativeName("displayID")]
    public uint DisplayId;

    [NativeName("format")]
    public PixelFormat Format;

    [NativeName("w")]
    public int W;

    [NativeName("h")]
    public int H;

    [NativeName("pixel_density")]
    public float PixelDensity;

    [NativeName("refresh_rate")]
    public float RefreshRate;

    [NativeName("refresh_rate_numerator")]
    public int RefreshRateNumerator;

    [NativeName("refresh_rate_denominator")]
    public int RefreshRateDenominator;

    [NativeName("@internal")]
    public DisplayModeDataHandle @internal;
}
