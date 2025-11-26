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
    public delegate* unmanaged<void*, nint, IOWhence, nint> Handle =>
        (delegate* unmanaged<void*, nint, IOWhence, nint>)Pointer;

    public IOStreamInterfaceSeek(delegate* unmanaged<void*, nint, IOWhence, nint> ptr) =>
        Pointer = ptr;

    public IOStreamInterfaceSeek(IOStreamInterfaceSeekDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IOStreamInterfaceSeek(
        delegate* unmanaged<void*, nint, IOWhence, nint> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, nint, IOWhence, nint>(
        IOStreamInterfaceSeek pfn
    ) => (delegate* unmanaged<void*, nint, IOWhence, nint>)pfn.Pointer;
}
