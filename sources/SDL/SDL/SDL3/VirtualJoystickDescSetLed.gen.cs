// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public readonly unsafe struct VirtualJoystickDescSetLed : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, byte, byte, byte, byte> Handle =>
        (delegate* unmanaged<void*, byte, byte, byte, byte>)Pointer;

    public VirtualJoystickDescSetLed(delegate* unmanaged<void*, byte, byte, byte, byte> ptr) =>
        Pointer = ptr;

    public VirtualJoystickDescSetLed(VirtualJoystickDescSetLedDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator VirtualJoystickDescSetLed(
        delegate* unmanaged<void*, byte, byte, byte, byte> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, byte, byte, byte, byte>(
        VirtualJoystickDescSetLed pfn
    ) => (delegate* unmanaged<void*, byte, byte, byte, byte>)pfn.Pointer;
}
