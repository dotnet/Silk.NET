// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public readonly unsafe struct TimerCallback : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, uint, uint, uint> Handle =>
        (delegate* unmanaged<void*, uint, uint, uint>)Pointer;

    public TimerCallback(delegate* unmanaged<void*, uint, uint, uint> ptr) => Pointer = ptr;

    public TimerCallback(TimerCallbackDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator TimerCallback(
        delegate* unmanaged<void*, uint, uint, uint> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, uint, uint, uint>(
        TimerCallback pfn
    ) => (delegate* unmanaged<void*, uint, uint, uint>)pfn.Pointer;
}