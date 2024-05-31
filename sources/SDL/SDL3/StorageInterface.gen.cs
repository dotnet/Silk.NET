// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public unsafe partial struct StorageInterface
{
    [NativeTypeName("int (*)(void *)")]
    public delegate* unmanaged<void*, int> Close;

    [NativeTypeName("SDL_bool (*)(void *)")]
    public delegate* unmanaged<void*, int> Ready;

    [NativeTypeName("int (*)(void *, const char *, SDL_EnumerateDirectoryCallback, void *)")]
    public delegate* unmanaged<
        void*,
        sbyte*,
        delegate* unmanaged<void*, sbyte*, sbyte*, int>,
        void*,
        int> Enumerate;

    [NativeTypeName("int (*)(void *, const char *, SDL_PathInfo *)")]
    public delegate* unmanaged<void*, sbyte*, PathInfo*, int> Info;

    [NativeTypeName("int (*)(void *, const char *, void *, Uint64)")]
    public delegate* unmanaged<void*, sbyte*, void*, ulong, int> ReadFile;

    [NativeTypeName("int (*)(void *, const char *, const void *, Uint64)")]
    public delegate* unmanaged<void*, sbyte*, void*, ulong, int> WriteFile;

    [NativeTypeName("int (*)(void *, const char *)")]
    public delegate* unmanaged<void*, sbyte*, int> Mkdir;

    [NativeTypeName("int (*)(void *, const char *)")]
    public delegate* unmanaged<void*, sbyte*, int> Remove;

    [NativeTypeName("int (*)(void *, const char *, const char *)")]
    public delegate* unmanaged<void*, sbyte*, sbyte*, int> Rename;

    [NativeTypeName("Uint64 (*)(void *)")]
    public delegate* unmanaged<void*, ulong> SpaceRemaining;
}
