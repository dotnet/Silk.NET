// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public readonly unsafe struct NSTimerCallback : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, uint, nuint, nuint> Handle =>
        (delegate* unmanaged<void*, uint, nuint, nuint>)Pointer;

    public NSTimerCallback(delegate* unmanaged<void*, uint, nuint, nuint> ptr) => Pointer = ptr;

    public NSTimerCallback(NSTimerCallbackDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator NSTimerCallback(
        delegate* unmanaged<void*, uint, nuint, nuint> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, uint, nuint, nuint>(
        NSTimerCallback pfn
    ) => (delegate* unmanaged<void*, uint, nuint, nuint>)pfn.Pointer;
}
