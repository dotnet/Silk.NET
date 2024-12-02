// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public readonly unsafe struct AppInitFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void**, int, sbyte**, AppResult> Handle =>
        (delegate* unmanaged<void**, int, sbyte**, AppResult>)Pointer;

    public AppInitFunc(delegate* unmanaged<void**, int, sbyte**, AppResult> ptr) => Pointer = ptr;

    public AppInitFunc(AppInitFuncDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator AppInitFunc(
        delegate* unmanaged<void**, int, sbyte**, AppResult> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void**, int, sbyte**, AppResult>(
        AppInitFunc pfn
    ) => (delegate* unmanaged<void**, int, sbyte**, AppResult>)pfn.Pointer;
}
