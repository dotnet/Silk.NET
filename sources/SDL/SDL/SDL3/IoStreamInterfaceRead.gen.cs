// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_IOStreamInterface_read")]
public readonly unsafe struct IoStreamInterfaceRead : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, void*, nuint, IoStatus*, nuint> Handle =>
        (delegate* unmanaged<void*, void*, nuint, IoStatus*, nuint>)Pointer;

    public IoStreamInterfaceRead(delegate* unmanaged<void*, void*, nuint, IoStatus*, nuint> ptr) =>
        Pointer = ptr;

    public IoStreamInterfaceRead(IoStreamInterfaceReadDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IoStreamInterfaceRead(
        delegate* unmanaged<void*, void*, nuint, IoStatus*, nuint> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, void*, nuint, IoStatus*, nuint>(
        IoStreamInterfaceRead pfn
    ) => (delegate* unmanaged<void*, void*, nuint, IoStatus*, nuint>)pfn.Pointer;
}
