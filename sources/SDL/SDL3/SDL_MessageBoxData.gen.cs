// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
namespace Silk.NET.SDL;

public unsafe partial struct MessageBoxData
{
    [NativeTypeName("Uint32")]
    public uint Flags;
    public SDL_Window* Window;

    [NativeTypeName("const char *")]
    public sbyte* Title;

    [NativeTypeName("const char *")]
    public sbyte* Message;
    public int Numbuttons;

    [NativeTypeName("const SDL_MessageBoxButtonData *")]
    public MessageBoxButtonData* Buttons;

    [NativeTypeName("const SDL_MessageBoxColorScheme *")]
    public MessageBoxColorScheme* ColorScheme;
}
