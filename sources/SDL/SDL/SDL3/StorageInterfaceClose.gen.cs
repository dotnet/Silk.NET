// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_StorageInterface_close")]
[Transformed]
public readonly unsafe struct StorageInterfaceClose : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, byte> Handle => (delegate* unmanaged<void*, byte>)Pointer;

    public StorageInterfaceClose(delegate* unmanaged<void*, byte> ptr) => Pointer = ptr;

    public StorageInterfaceClose(StorageInterfaceCloseDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator StorageInterfaceClose(delegate* unmanaged<void*, byte> pfn) =>
        new(pfn);

    public static implicit operator delegate* unmanaged<void*, byte>(StorageInterfaceClose pfn) =>
        (delegate* unmanaged<void*, byte>)pfn.Pointer;
}
