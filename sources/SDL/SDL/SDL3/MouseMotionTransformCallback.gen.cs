// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_MouseMotionTransformCallback")]
public readonly unsafe struct MouseMotionTransformCallback : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, ulong, WindowHandle, uint, float*, float*, void> Handle =>
        (delegate* unmanaged<void*, ulong, WindowHandle, uint, float*, float*, void>)Pointer;

    public MouseMotionTransformCallback(
        delegate* unmanaged<void*, ulong, WindowHandle, uint, float*, float*, void> ptr
    ) => Pointer = ptr;

    public MouseMotionTransformCallback(MouseMotionTransformCallbackDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator MouseMotionTransformCallback(
        delegate* unmanaged<void*, ulong, WindowHandle, uint, float*, float*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        void*,
        ulong,
        WindowHandle,
        uint,
        float*,
        float*,
        void>(MouseMotionTransformCallback pfn) =>
        (delegate* unmanaged<void*, ulong, WindowHandle, uint, float*, float*, void>)pfn.Pointer;
}
