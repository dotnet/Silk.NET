// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[Transformed]
public readonly unsafe struct IOStreamInterfaceSeek : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, long, IOWhence, long> Handle =>
        (delegate* unmanaged<void*, long, IOWhence, long>)Pointer;

    public IOStreamInterfaceSeek(delegate* unmanaged<void*, long, IOWhence, long> ptr) =>
        Pointer = ptr;

    public IOStreamInterfaceSeek(IOStreamInterfaceSeekDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IOStreamInterfaceSeek(
        delegate* unmanaged<void*, long, IOWhence, long> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, long, IOWhence, long>(
        IOStreamInterfaceSeek pfn
    ) => (delegate* unmanaged<void*, long, IOWhence, long>)pfn.Pointer;
}
