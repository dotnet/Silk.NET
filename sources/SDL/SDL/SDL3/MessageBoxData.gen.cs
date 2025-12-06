// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_MessageBoxData")]
public unsafe partial struct MessageBoxData
{
    [NativeName("flags")]
    public uint Flags;

    [NativeName("window")]
    public WindowHandle Window;

    [NativeName("title")]
    public sbyte* Title;

    [NativeName("message")]
    public sbyte* Message;

    [NativeName("numbuttons")]
    public int Numbuttons;

    [NativeName("buttons")]
    public MessageBoxButtonData* Buttons;

    [NativeName("colorScheme")]
    public MessageBoxColorScheme* ColorScheme;
}
