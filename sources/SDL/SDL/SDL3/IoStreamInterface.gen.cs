// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_IOStreamInterface")]
public unsafe partial struct IoStreamInterface
{
    [NativeName("version")]
    public uint Version;

    [NativeName("size")]
    public IoStreamInterfaceSize Size;

    [NativeName("seek")]
    public IoStreamInterfaceSeek Seek;

    [NativeName("read")]
    public IoStreamInterfaceRead Read;

    [NativeName("write")]
    public IoStreamInterfaceWrite Write;

    [NativeName("flush")]
    public IoStreamInterfaceFlush Flush;

    [NativeName("close")]
    public IoStreamInterfaceClose Close;
}
