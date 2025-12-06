// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public unsafe partial struct MessageBoxButtonData
{
    [NativeTypeName("SDL_MessageBoxButtonFlags")]
    public uint Flags;
    public int ButtonID;

    [NativeTypeName("const char *")]
    public sbyte* Text;
}
