// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_StorageInterface_rename")]
public readonly unsafe struct StorageInterfaceRename : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, sbyte*, sbyte*, byte> Handle =>
        (delegate* unmanaged<void*, sbyte*, sbyte*, byte>)Pointer;

    public StorageInterfaceRename(delegate* unmanaged<void*, sbyte*, sbyte*, byte> ptr) =>
        Pointer = ptr;

    public StorageInterfaceRename(StorageInterfaceRenameDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator StorageInterfaceRename(
        delegate* unmanaged<void*, sbyte*, sbyte*, byte> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, sbyte*, sbyte*, byte>(
        StorageInterfaceRename pfn
    ) => (delegate* unmanaged<void*, sbyte*, sbyte*, byte>)pfn.Pointer;
}
