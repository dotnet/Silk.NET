// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

public unsafe partial struct IoStreamInterface
{
    [NativeTypeName("Uint32")]
    public uint Version;

    [NativeTypeName("Sint64 (*)(void *)")]
    public IoStreamInterfaceSize Size;

    [NativeTypeName("Sint64 (*)(void *, Sint64, SDL_IOWhence)")]
    public IoStreamInterfaceSeek Seek;

    [NativeTypeName("size_t (*)(void *, void *, size_t, SDL_IOStatus *)")]
    public IoStreamInterfaceRead Read;

    [NativeTypeName("size_t (*)(void *, const void *, size_t, SDL_IOStatus *)")]
    public IoStreamInterfaceWrite Write;

    [NativeTypeName("bool (*)(void *, SDL_IOStatus *)")]
    public IoStreamInterfaceFlush Flush;

    [NativeTypeName("bool (*)(void *)")]
    public IoStreamInterfaceClose Close;
}
