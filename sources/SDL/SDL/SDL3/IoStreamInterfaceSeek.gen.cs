// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_IOStreamInterface_seek")]
public readonly unsafe struct IoStreamInterfaceSeek : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, nint, IoWhence, nint> Handle =>
        (delegate* unmanaged<void*, nint, IoWhence, nint>)Pointer;

    public IoStreamInterfaceSeek(delegate* unmanaged<void*, nint, IoWhence, nint> ptr) =>
        Pointer = ptr;

    public IoStreamInterfaceSeek(IoStreamInterfaceSeekDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IoStreamInterfaceSeek(
        delegate* unmanaged<void*, nint, IoWhence, nint> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, nint, IoWhence, nint>(
        IoStreamInterfaceSeek pfn
    ) => (delegate* unmanaged<void*, nint, IoWhence, nint>)pfn.Pointer;
}
