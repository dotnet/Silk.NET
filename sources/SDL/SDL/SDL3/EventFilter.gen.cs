// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public readonly unsafe struct EventFilter : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, Event*, byte> Handle =>
        (delegate* unmanaged<void*, Event*, byte>)Pointer;

    public EventFilter(delegate* unmanaged<void*, Event*, byte> ptr) => Pointer = ptr;

    public EventFilter(EventFilterDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator EventFilter(delegate* unmanaged<void*, Event*, byte> pfn) =>
        new(pfn);

    public static implicit operator delegate* unmanaged<void*, Event*, byte>(EventFilter pfn) =>
        (delegate* unmanaged<void*, Event*, byte>)pfn.Pointer;
}
