// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public readonly unsafe struct VirtualJoystickDescCleanup : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, void> Handle => (delegate* unmanaged<void*, void>)Pointer;

    public VirtualJoystickDescCleanup(delegate* unmanaged<void*, void> ptr) => Pointer = ptr;

    public VirtualJoystickDescCleanup(VirtualJoystickDescCleanupDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator VirtualJoystickDescCleanup(
        delegate* unmanaged<void*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, void>(
        VirtualJoystickDescCleanup pfn
    ) => (delegate* unmanaged<void*, void>)pfn.Pointer;
}