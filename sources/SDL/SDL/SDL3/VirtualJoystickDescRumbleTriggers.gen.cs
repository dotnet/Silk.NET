// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public readonly unsafe struct VirtualJoystickDescRumbleTriggers : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, ushort, ushort, byte> Handle =>
        (delegate* unmanaged<void*, ushort, ushort, byte>)Pointer;

    public VirtualJoystickDescRumbleTriggers(
        delegate* unmanaged<void*, ushort, ushort, byte> ptr
    ) => Pointer = ptr;

    public VirtualJoystickDescRumbleTriggers(VirtualJoystickDescRumbleTriggersDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator VirtualJoystickDescRumbleTriggers(
        delegate* unmanaged<void*, ushort, ushort, byte> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, ushort, ushort, byte>(
        VirtualJoystickDescRumbleTriggers pfn
    ) => (delegate* unmanaged<void*, ushort, ushort, byte>)pfn.Pointer;
}
