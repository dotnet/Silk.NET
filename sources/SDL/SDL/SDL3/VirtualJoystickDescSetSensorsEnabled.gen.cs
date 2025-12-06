// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[NativeName("SDL_VirtualJoystickDesc_SetSensorsEnabled")]
public readonly unsafe struct VirtualJoystickDescSetSensorsEnabled : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, byte, byte> Handle =>
        (delegate* unmanaged<void*, byte, byte>)Pointer;

    public VirtualJoystickDescSetSensorsEnabled(delegate* unmanaged<void*, byte, byte> ptr) =>
        Pointer = ptr;

    public VirtualJoystickDescSetSensorsEnabled(
        VirtualJoystickDescSetSensorsEnabledDelegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator VirtualJoystickDescSetSensorsEnabled(
        delegate* unmanaged<void*, byte, byte> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, byte, byte>(
        VirtualJoystickDescSetSensorsEnabled pfn
    ) => (delegate* unmanaged<void*, byte, byte>)pfn.Pointer;
}
