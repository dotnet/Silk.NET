// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_AudioStreamDataCompleteCallback")]
public readonly unsafe struct AudioStreamDataCompleteCallback : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, void*, int, void> Handle =>
        (delegate* unmanaged<void*, void*, int, void>)Pointer;

    public AudioStreamDataCompleteCallback(delegate* unmanaged<void*, void*, int, void> ptr) =>
        Pointer = ptr;

    public AudioStreamDataCompleteCallback(AudioStreamDataCompleteCallbackDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator AudioStreamDataCompleteCallback(
        delegate* unmanaged<void*, void*, int, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, void*, int, void>(
        AudioStreamDataCompleteCallback pfn
    ) => (delegate* unmanaged<void*, void*, int, void>)pfn.Pointer;
}
