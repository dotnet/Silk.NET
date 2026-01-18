// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_IOStreamInterface_flush")]
public readonly unsafe struct IOStreamInterfaceFlush : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, IOStatus*, byte> Handle =>
        (delegate* unmanaged<void*, IOStatus*, byte>)Pointer;

    public IOStreamInterfaceFlush(delegate* unmanaged<void*, IOStatus*, byte> ptr) => Pointer = ptr;

    public IOStreamInterfaceFlush(IOStreamInterfaceFlushDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IOStreamInterfaceFlush(
        delegate* unmanaged<void*, IOStatus*, byte> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, IOStatus*, byte>(
        IOStreamInterfaceFlush pfn
    ) => (delegate* unmanaged<void*, IOStatus*, byte>)pfn.Pointer;
}
