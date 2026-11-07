// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_ThreadFunction")]
public readonly unsafe struct ThreadFunction : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, int> Handle => (delegate* unmanaged<void*, int>)Pointer;

    public ThreadFunction(delegate* unmanaged<void*, int> ptr) => Pointer = ptr;

    public ThreadFunction(ThreadFunctionDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator ThreadFunction(delegate* unmanaged<void*, int> pfn) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, int>(ThreadFunction pfn) =>
        (delegate* unmanaged<void*, int>)pfn.Pointer;
}
