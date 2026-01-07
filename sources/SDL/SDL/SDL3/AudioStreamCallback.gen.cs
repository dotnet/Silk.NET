// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_AudioStreamCallback")]
public readonly unsafe struct AudioStreamCallback : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, AudioStreamHandle, int, int, void> Handle =>
        (delegate* unmanaged<void*, AudioStreamHandle, int, int, void>)Pointer;

    public AudioStreamCallback(delegate* unmanaged<void*, AudioStreamHandle, int, int, void> ptr) =>
        Pointer = ptr;

    public AudioStreamCallback(AudioStreamCallbackDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator AudioStreamCallback(
        delegate* unmanaged<void*, AudioStreamHandle, int, int, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, AudioStreamHandle, int, int, void>(
        AudioStreamCallback pfn
    ) => (delegate* unmanaged<void*, AudioStreamHandle, int, int, void>)pfn.Pointer;
}
