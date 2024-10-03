// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.SDL.ArrayOrder;
using static Silk.NET.SDL.BitmapOrder;
using static Silk.NET.SDL.PackedLayout;
using static Silk.NET.SDL.PackedOrder;
using static Silk.NET.SDL.PixelType;

namespace Silk.NET.SDL;

public unsafe partial struct StorageInterface
{
    [NativeTypeName("int (*)(void *)")]
    public ThreadFunction Close;

    [NativeTypeName("SDL_bool (*)(void *)")]
    public ThreadFunction Ready;

    [NativeTypeName("int (*)(void *, const char *, SDL_EnumerateDirectoryCallback, void *)")]
    public StorageInterfaceEnumerate Enumerate;

    [NativeTypeName("int (*)(void *, const char *, SDL_PathInfo *)")]
    public StorageInterfaceInfo Info;

    [NativeTypeName("int (*)(void *, const char *, void *, Uint64)")]
    public StorageInterfaceFunction1 ReadFile;

    [NativeTypeName("int (*)(void *, const char *, const void *, Uint64)")]
    public StorageInterfaceFunction1 WriteFile;

    [NativeTypeName("int (*)(void *, const char *)")]
    public StorageInterfaceFunction2 Mkdir;

    [NativeTypeName("int (*)(void *, const char *)")]
    public StorageInterfaceFunction2 Remove;

    [NativeTypeName("int (*)(void *, const char *, const char *)")]
    public EnumerateDirectoryCallback Rename;

    [NativeTypeName("Uint64 (*)(void *)")]
    public StorageInterfaceSpaceRemaining SpaceRemaining;
}
