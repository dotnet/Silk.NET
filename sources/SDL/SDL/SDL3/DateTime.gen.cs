// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_DateTime")]
public partial struct DateTime
{
    [NativeName("year")]
    public int Year;

    [NativeName("month")]
    public int Month;

    [NativeName("day")]
    public int Day;

    [NativeName("hour")]
    public int Hour;

    [NativeName("minute")]
    public int Minute;

    [NativeName("second")]
    public int Second;

    [NativeName("nanosecond")]
    public int Nanosecond;

    [NativeName("day_of_week")]
    public int DayOfWeek;

    [NativeName("utc_offset")]
    public int UtcOffset;
}
