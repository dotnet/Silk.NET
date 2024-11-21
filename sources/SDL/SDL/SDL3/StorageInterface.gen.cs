// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public unsafe partial struct StorageInterface
{
    [NativeTypeName("Uint32")]
    public uint Version;

    [NativeTypeName("bool (*)(void *)")]
    public StorageInterfaceClose Close;

    [NativeTypeName("bool (*)(void *)")]
    public StorageInterfaceReady Ready;

    [NativeTypeName("bool (*)(void *, const char *, SDL_EnumerateDirectoryCallback, void *)")]
    public StorageInterfaceEnumerate Enumerate;

    [NativeTypeName("bool (*)(void *, const char *, SDL_PathInfo *)")]
    public StorageInterfaceInfo Info;

    [NativeTypeName("bool (*)(void *, const char *, void *, Uint64)")]
    public StorageInterfaceReadFile ReadFile;

    [NativeTypeName("bool (*)(void *, const char *, const void *, Uint64)")]
    public StorageInterfaceWriteFile WriteFile;

    [NativeTypeName("bool (*)(void *, const char *)")]
    public StorageInterfaceMkdir Mkdir;

    [NativeTypeName("bool (*)(void *, const char *)")]
    public StorageInterfaceRemove Remove;

    [NativeTypeName("bool (*)(void *, const char *, const char *)")]
    public StorageInterfaceRename Rename;

    [NativeTypeName("bool (*)(void *, const char *, const char *)")]
    public StorageInterfaceCopy Copy;

    [NativeTypeName("Uint64 (*)(void *)")]
    public StorageInterfaceSpaceRemaining SpaceRemaining;
}
