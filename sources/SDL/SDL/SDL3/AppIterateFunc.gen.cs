// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_AppIterate_func")]
public readonly unsafe struct AppIterateFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, AppResult> Handle =>
        (delegate* unmanaged<void*, AppResult>)Pointer;

    public AppIterateFunc(delegate* unmanaged<void*, AppResult> ptr) => Pointer = ptr;

    public AppIterateFunc(AppIterateFuncDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator AppIterateFunc(delegate* unmanaged<void*, AppResult> pfn) =>
        new(pfn);

    public static implicit operator delegate* unmanaged<void*, AppResult>(AppIterateFunc pfn) =>
        (delegate* unmanaged<void*, AppResult>)pfn.Pointer;
}
