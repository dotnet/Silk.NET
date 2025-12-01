// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_TextEditingEvent")]
public unsafe partial struct TextEditingEvent
{
    [NativeName("type")]
    public EventType Type;

    [NativeName("reserved")]
    public uint Reserved;

    [NativeName("timestamp")]
    public nuint Timestamp;

    [NativeName("windowID")]
    public uint WindowId;

    [NativeName("text")]
    public sbyte* Text;

    [NativeName("start")]
    public int Start;

    [NativeName("length")]
    public int Length;
}
