// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_IOStreamInterface_write")]
public readonly unsafe struct IOStreamInterfaceWrite : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, void*, nuint, IOStatus*, nuint> Handle =>
        (delegate* unmanaged<void*, void*, nuint, IOStatus*, nuint>)Pointer;

    public IOStreamInterfaceWrite(delegate* unmanaged<void*, void*, nuint, IOStatus*, nuint> ptr) =>
        Pointer = ptr;

    public IOStreamInterfaceWrite(IOStreamInterfaceWriteDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IOStreamInterfaceWrite(
        delegate* unmanaged<void*, void*, nuint, IOStatus*, nuint> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, void*, nuint, IOStatus*, nuint>(
        IOStreamInterfaceWrite pfn
    ) => (delegate* unmanaged<void*, void*, nuint, IOStatus*, nuint>)pfn.Pointer;
}
