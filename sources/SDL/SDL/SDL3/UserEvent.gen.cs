// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_UserEvent")]
public unsafe partial struct UserEvent
{
    [NativeName("type")]
    public uint Type;

    [NativeName("reserved")]
    public uint Reserved;

    [NativeName("timestamp")]
    public nuint Timestamp;

    [NativeName("windowID")]
    public uint WindowID;

    [NativeName("code")]
    public int Code;

    [NativeName("data1")]
    public void* Data1;

    [NativeName("data2")]
    public void* Data2;
}
