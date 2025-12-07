// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public readonly unsafe struct AppQuitFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, AppResult, void> Handle =>
        (delegate* unmanaged<void*, AppResult, void>)Pointer;

    public AppQuitFunc(delegate* unmanaged<void*, AppResult, void> ptr) => Pointer = ptr;

    public AppQuitFunc(AppQuitFuncDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator AppQuitFunc(delegate* unmanaged<void*, AppResult, void> pfn) =>
        new(pfn);

    public static implicit operator delegate* unmanaged<void*, AppResult, void>(AppQuitFunc pfn) =>
        (delegate* unmanaged<void*, AppResult, void>)pfn.Pointer;
}
