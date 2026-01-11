// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_StorageInterface")]
public unsafe partial struct StorageInterface
{
    [NativeName("version")]
    public uint Version;

    [NativeName("close")]
    public StorageInterfaceClose Close;

    [NativeName("ready")]
    public StorageInterfaceReady Ready;

    [NativeName("enumerate")]
    public StorageInterfaceEnumerate Enumerate;

    [NativeName("info")]
    public StorageInterfaceInfo Info;

    [NativeName("read_file")]
    public StorageInterfaceReadFile ReadFile;

    [NativeName("write_file")]
    public StorageInterfaceWriteFile WriteFile;

    [NativeName("mkdir")]
    public StorageInterfaceMkdir Mkdir;

    [NativeName("remove")]
    public StorageInterfaceRemove Remove;

    [NativeName("rename")]
    public StorageInterfaceRename Rename;

    [NativeName("copy")]
    public StorageInterfaceCopy Copy;

    [NativeName("space_remaining")]
    public StorageInterfaceSpaceRemaining SpaceRemaining;
}
