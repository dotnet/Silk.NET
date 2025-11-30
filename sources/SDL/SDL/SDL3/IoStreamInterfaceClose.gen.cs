// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_IOStreamInterface_close")]
[Transformed]
public readonly unsafe struct IoStreamInterfaceClose : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, byte> Handle => (delegate* unmanaged<void*, byte>)Pointer;

    public IoStreamInterfaceClose(delegate* unmanaged<void*, byte> ptr) => Pointer = ptr;

    public IoStreamInterfaceClose(IoStreamInterfaceCloseDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator IoStreamInterfaceClose(delegate* unmanaged<void*, byte> pfn) =>
        new(pfn);

    public static implicit operator delegate* unmanaged<void*, byte>(IoStreamInterfaceClose pfn) =>
        (delegate* unmanaged<void*, byte>)pfn.Pointer;
}
