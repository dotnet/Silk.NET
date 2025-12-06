// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_StorageInterface_space_remaining")]
public readonly unsafe struct StorageInterfaceSpaceRemaining : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, ulong> Handle => (delegate* unmanaged<void*, ulong>)Pointer;

    public StorageInterfaceSpaceRemaining(delegate* unmanaged<void*, ulong> ptr) => Pointer = ptr;

    public StorageInterfaceSpaceRemaining(StorageInterfaceSpaceRemainingDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator StorageInterfaceSpaceRemaining(
        delegate* unmanaged<void*, ulong> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, ulong>(
        StorageInterfaceSpaceRemaining pfn
    ) => (delegate* unmanaged<void*, ulong>)pfn.Pointer;
}
